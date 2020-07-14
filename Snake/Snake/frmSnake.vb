Public Class frmSnake
    Dim rand As New Random
    Dim gameWindowSize As Point = New Point(600, 600)

    Dim tileSize As Integer = 25

    Dim tileEmpty As Integer = 0
    Dim tileWall As Integer = 1
    Dim tileFood As Integer = 2
    Dim tileSnake As Integer = 3

    Dim tileColors() As Color = {Color.LawnGreen, Color.Black, Color.Red, Color.Blue}

    Dim spaceAllocation(,) As Integer
    Dim picAllocation(,) As PictureBox
    Dim snakeSegments() As Point

    Dim directionalButtons(3) As Button
    Dim direction As Integer
    Dim score As Integer
    Dim highScore As Integer

    'Load Form
    Private Sub frmSnake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'Hide
        For index = 0 To Me.Controls.Count - 1
            Me.Controls.Item(index).Visible = False
        Next
        btnStart.Visible = True
        btnReset.Visible = True

        direction = rand.Next(0, 4)

        directionalButtons(0) = btnUp
        directionalButtons(1) = btnRight
        directionalButtons(2) = btnDown
        directionalButtons(3) = btnLeft

        LoadData()
    End Sub

    'Start Button
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Reveal
        For index = 0 To Me.Controls.Count - 1
            Me.Controls.Item(index).Visible = True
        Next
        StartGame()
        Me.Controls.Remove(btnStart)
        Me.Controls.Remove(btnReset)
    End Sub

    'Reset Button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.highScore = 0
        highScore = 0
        Me.Controls.Remove(btnReset)
    End Sub

    'Start Game
    Sub StartGame()
        tmrMain.Enabled = True
        tmrTime.Enabled = True
        ReDim spaceAllocation(gameWindowSize.X / tileSize, gameWindowSize.Y / tileSize) '24,24
        ReDim picAllocation(gameWindowSize.X / tileSize, gameWindowSize.Y / tileSize)
        Me.WindowState = FormWindowState.Maximized
        CreateLayout()
        CreateSnake()
        CreateFood()
        ShowAllocation()
    End Sub

    'Create Layout at Start of Game
    Sub CreateLayout()
        For indexY = 0 To gameWindowSize.Y Step tileSize
            For indexX = 0 To gameWindowSize.X Step tileSize

                Dim tile As New PictureBox
                With tile
                    .Location = New Point(indexX, indexY)
                    .Size = New Point(tileSize - 1, tileSize - 1)
                    .BackColor = tileColors(0)
                End With

                spaceAllocation(indexX / tileSize, indexY / tileSize) = 0
                picAllocation(indexX / tileSize, indexY / tileSize) = (tile)
                Me.Controls.Add(tile)
            Next
        Next
        CreateWalls()
    End Sub

    'Create Walls
    Sub CreateWalls()
        For indexY = 0 To 24
            For indexX = 0 To 24
                If indexX <= 0 Or indexX >= 24 Or indexY <= 0 Or indexY >= 24 Then
                    ChangeTile(indexX, indexY, 1)
                End If
            Next
        Next
    End Sub

    'Finds empty tile space for use returns allocation XY coords
    Function FindSpace() As Point
        Dim space(0) As Point

        For indexY = 0 To tileSize - 1
            For indexX = 0 To tileSize - 1
                If spaceAllocation(indexX, indexY) = 0 Then
                    space(space.Length - 1) = New Point(indexX, indexY)
                    ReDim Preserve space(space.Length)
                End If
            Next
        Next

        Return space(rand.Next(0, space.Length - 1))
    End Function

    'Create Food
    Sub CreateFood()
        Dim space As Point = FindSpace()
        ChangeTile(space.X, space.Y, 2)
    End Sub

    'Create Snake
    Sub CreateSnake()
        ChangeTile(12, 12, 3)
        ReDim snakeSegments(0)
        snakeSegments(0) = New Point(12, 12)
    End Sub

    'Update Snake
    Sub UpdateSnake()
        Static newLoc As Point
        Static lastLoc As Point
        Static storeLoc As Point
        Dim toAdd As Boolean

        Select Case direction
            Case 0
                newLoc = New Point(snakeSegments(0).X, snakeSegments(0).Y - 1)
            Case 1
                newLoc = New Point(snakeSegments(0).X + 1, snakeSegments(0).Y)
            Case 2
                newLoc = New Point(snakeSegments(0).X, snakeSegments(0).Y + 1)
            Case 3
                newLoc = New Point(snakeSegments(0).X - 1, snakeSegments(0).Y)
        End Select

        If spaceAllocation(newLoc.X, newLoc.Y) = 1 Or spaceAllocation(newLoc.X, newLoc.Y) = 3 Then
            EndGame(spaceAllocation(newLoc.X, newLoc.Y))
            Exit Sub
        ElseIf spaceAllocation(newLoc.X, newLoc.Y) = 2 Then
            toAdd = True
        End If

        'General Relocation Logic
        For index = 0 To snakeSegments.Length - 1

            If index = 0 Then
                'Head

                lastLoc = snakeSegments(0)

                ChangeTile(newLoc.X, newLoc.Y, 3)
                snakeSegments(0) = newLoc

                ChangeTile(lastLoc.X, lastLoc.Y, 0)
            Else
                'Segments

                storeLoc = snakeSegments(index)

                ChangeTile(lastLoc.X, lastLoc.Y, 3)
                snakeSegments(index) = lastLoc

                lastLoc = storeLoc
                ChangeTile(storeLoc.X, storeLoc.Y, 0)
            End If
        Next

        If toAdd Then
            AddSegment(lastLoc)
        End If
    End Sub

    'Add segment to Snake
    Sub AddSegment(loc As Point)
        score += 10
        ReDim Preserve snakeSegments(snakeSegments.Length)
        ChangeTile(loc.X, loc.Y, 3)
        snakeSegments(snakeSegments.Length - 1) = New Point(loc.X, loc.Y)
        CreateFood()
    End Sub

    'Change Tile using XY coords
    Sub ChangeTile(x As Integer, y As Integer, newTile As Integer)
        spaceAllocation(x, y) = newTile
        picAllocation(x, y).BackColor = tileColors(newTile)
        ShowAllocation()
    End Sub

    'Update Timer
    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        highScore = If(score > highScore, score, highScore)
        lblHighScore.Text = "High Score: " & highScore
        lblScore.Text = "Score: " & score
        lblSegments.Text = "Segments: " & snakeSegments.Length

        Select Case direction
            Case 0
                lblDirection.Text = "Direction: (0) North"
            Case 1
                lblDirection.Text = "Direction: (1) East"
            Case 2
                lblDirection.Text = "Direction: (2) South"
            Case 3
                lblDirection.Text = "Direction: (3) West"
        End Select

        UpdateSnake()
    End Sub

    'Time Timer
    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        Static time As Integer
        lblTime.Text = "Time: " & time
        time += 1
    End Sub

    'End Game
    Sub EndGame(deathCause As Integer)
        tmrMain.Enabled = False
        MessageBox.Show(If(deathCause = 1, "You Slithered into a Wall!", "You Slithered into Yourself for petes snake!"), "Snake", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SaveData()
        Application.Restart()
    End Sub

    'Show Grid data and other information
    Sub ShowAllocation()
        lisSpace.Items.Clear()
        Dim allocationLine As String

        For indexY = 0 To tileSize - 1
            For indexX = 0 To tileSize - 1
                allocationLine += spaceAllocation(indexX, indexY).ToString & " "
            Next

            lisSpace.Items.Add(allocationLine)
            allocationLine = Nothing
        Next
    End Sub

    'DIRECTIONAL BUTTONS

    'Up
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        direction = 0
        UpdateButtons()
        With btnDown
            .Enabled = False
            .BackColor = Color.SlateGray
        End With
    End Sub

    'Right
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        direction = 1
        UpdateButtons()
        With btnLeft
            .Enabled = False
            .BackColor = Color.SlateGray
        End With
    End Sub

    'Down
    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        direction = 2
        UpdateButtons()
        With btnUp
            .Enabled = False
            .BackColor = Color.SlateGray
        End With
    End Sub

    'Left
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        direction = 3
        UpdateButtons()
        With btnRight
            .Enabled = False
            .BackColor = Color.SlateGray
        End With
    End Sub

    'Reset Disabled Buttons
    Sub UpdateButtons()
        For index = 0 To directionalButtons.Length - 1
            With directionalButtons(index)
                .Enabled = True
                .BackColor = Color.Red
            End With
        Next
    End Sub

    'Save Settings
    Sub SaveData()
        My.Settings.highScore = highScore
    End Sub

    'Load Settings
    Sub LoadData()
        highScore = My.Settings.highScore
    End Sub
End Class

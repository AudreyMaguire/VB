Module Module1

    Sub Main()
        Dim firstName As String
        Dim middleIntial As Char
        Dim lastName As String
        Dim fullName As String
        Dim age As Integer
        Dim isCitizen As Boolean
        Dim canVote As Boolean
        Dim heightFeet As Integer
        Dim heightInches As Decimal
        Dim totalHeightCM As Decimal

        firstName = "Audrey"
        middleIntial = "B"
        lastName = "Maguire"
        fullName = firstName & " " & middleIntial & "." & lastName
        age = 19
        heightFeet = 5
        heightInches = 7

        Dim totalHeightInches As Decimal = heightFeet * 12 + heightInches

        totalHeightCM = 2.54 * totalHeightInches

        isCitizen = True
        canVote = isCitizen And age >= 18







    End Sub

End Module

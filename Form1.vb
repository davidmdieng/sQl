Public Class Form1



    Private Sub btncall_Click(sender As Object, e As EventArgs) Handles btncall.Click


        MsgBox("Hello word")
        MsgBox("How are you doing")
        MsgBox("are you good?")

        MessageBox.Show("Thanks for the lesson")


    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click



        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kevin"
        stLastName = "Moris"

        MsgBox("hello welcome to this class " + stFirstName + " " + stLastName + " This is an exciting course")

        stFirstName = "Pablo"
        stLastName = "Mary"


        MsgBox(" hello welcome to this course " + stFirstName + " " + stLastName + " This course will be great")



    End Sub

    Private Sub btndat_type_Click(sender As Object, e As EventArgs) Handles btndat_type.Click

        Dim stMake As String
        Dim stModal As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim dPrice As Decimal
        Dim dtDateRegistered As Date


        stMake = "Honda"
        stModal = "Civic"
        iDoors = 4
        stColor = " Purple"
        bTaxed = True
        iEngineSize = 1200
        dPrice = 2500.95
        dtDateRegistered = #03/28/2024#

        MsgBox("the car is " & stMake & vbNewLine & stModal & vbNewLine & iDoors &
               vbNewLine & stColor & vbNewLine & bTaxed & vbNewLine & iEngineSize &
               vbNewLine & dPrice & vbNewLine & dtDateRegistered)




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String


        stFirstName = txtFirstName.Text


        stLastName = txtboxLastName.Text
        stGender = textGender.Text


        stOccupation = lstOccupation.SelectedItem

        MsgBox(" Hello " & " " & stFirstName & " " & stLastName & "  You are " & stGender & " " & stOccupation)





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add(" Writer")
        lstOccupation.Items.Add("Player")
        lstOccupation.Items.Add("Dancer")




    End Sub
End Class

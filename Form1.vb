Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spPuerto.Open()
        inicializar()
    End Sub

    Private Sub inicializar()
        spPuerto.Write("2")
        spPuerto.Write("4")
        spPuerto.Write("6")
    End Sub

    Private Sub rbtRojoEncender_Click(sender As Object, e As EventArgs) Handles rbtRojoEncender.Click
        spPuerto.Write("1")
    End Sub

    Private Sub rbtRojoApagar_Click(sender As Object, e As EventArgs) Handles rbtRojoApagar.Click
        spPuerto.Write("2")
    End Sub

    Private Sub rbtVerdeEncender_Click(sender As Object, e As EventArgs) Handles rbtVerdeEncender.Click
        spPuerto.Write("3")
    End Sub

    Private Sub rbtVerdeApagar_Click(sender As Object, e As EventArgs) Handles rbtVerdeApagar.Click
        spPuerto.Write("4")
    End Sub

    Private Sub rbtAzulEncender_Click(sender As Object, e As EventArgs) Handles rbtAzulEncender.Click
        spPuerto.Write("5")
    End Sub

    Private Sub rbtAzulApagar_Click(sender As Object, e As EventArgs) Handles rbtAzulApagar.Click
        spPuerto.Write("6")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        spPuerto.Close()
    End Sub
End Class









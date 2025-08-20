Imports System.ComponentModel.DataAnnotations

Namespace DxThemeVariablesExample.Models

    Public Class Customer

        <Required>
        <MinLength(3, ErrorMessage:="Name is too short.")>
        Public Property Name As String

        Public Property Age As Integer?
    End Class
End Namespace

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Descrição da aplicação"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Página de contato"

        Return View()
    End Function
End Class

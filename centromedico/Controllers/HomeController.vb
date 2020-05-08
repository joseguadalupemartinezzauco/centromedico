Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function citas() As ActionResult
        Return View()
    End Function
    Function medicos() As ActionResult
        Return View()
    End Function
    Function pacientes() As ActionResult
        Return View()
    End Function
    Function consultorios() As ActionResult
        Return View()
    End Function
    Function especialidades() As ActionResult
        Return View()
    End Function
    Function usuarios() As ActionResult
        Return View()
    End Function
    Function reportes() As ActionResult
        Return View()
    End Function
    Function AgregarCita() As ActionResult
        Return View()
    End Function
End Class

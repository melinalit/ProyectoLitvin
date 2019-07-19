<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="PresentacionWeb.AltaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 191px;
        }
        .auto-style3 {
            width: 191px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div> 
            <h2>Ingrese Alumno</h2>

        </div>
    <table class="table" style="width:100%;">
        <tr>
            <td class="auto-style2">DNI:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellido:</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nombre:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnEnviar" runat="server" CssClass="btn-primary"  Text="Enviar" OnClick="btnEnviar_Click" />
            </td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>

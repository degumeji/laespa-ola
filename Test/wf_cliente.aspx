﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wf_cliente.aspx.cs" Inherits="Test.wf_cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interfaz Web</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <%--<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>--%>

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="author" content="Derek Mejia" />
</head>
<body style="height: 100%; margin: 0; padding: 0;">
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <h3>Clientes</h3>

        <!-- MENSAJES -->
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <asp:Label class="label label-success" ForeColor="Green" runat="server" ID="lblMensaje" />
                <asp:Label class="label label-danger" ForeColor="Red" runat="server" ID="lblError" />
            </ContentTemplate>
        </asp:UpdatePanel>

        <!-- DATOS DEL CLIENTE -->
        <asp:Label ID="Label1" Font-Size="Medium" Font-Bold="true" Text="Datos del Cliente" runat="server" />
        <br />

        <!-- ID -->
        <asp:Label ID="Label9" Font-Size="Medium" Text="ID:" runat="server" />
        <asp:TextBox ID="txtId" CssClass="text form-control text-right" runat="server" Enabled="true" Font-Size="12px" />
        <br />

        <!-- CEDULA -->
        <asp:Label ID="lblCedula" Font-Size="Medium" Text="Cedula:" runat="server" />
        <asp:TextBox ID="txtCedula" CssClass="text form-control text-right" runat="server" Enabled="true" Font-Size="12px" />
        <br />

        <!-- NOMBRE - APELLIDO -->
        <asp:Label ID="Label2" Font-Size="Medium" Text="Nombre:" runat="server" />
        <asp:TextBox ID="txtNombre" CssClass="text form-control text-right" runat="server" Enabled="true" Font-Size="12px" />
        <asp:Label ID="Label3" Font-Size="Medium" Text="Apellido:" runat="server" />
        <asp:TextBox ID="txtApellido" CssClass="text form-control text-right" runat="server" Enabled="true" Font-Size="12px" />
        <br />

        <!-- EDAD -->
        <asp:Label ID="lblEdad" Font-Size="Medium" Text="Edad:" runat="server" />
        <asp:TextBox ID="txtEdad" CssClass="text form-control text-right" runat="server" Enabled="true" Font-Size="12px" />
        <br />

        <!-- GENERO - ESTADO -->
        <asp:Label ID="Label4" Font-Size="Medium" Text="Género:" runat="server" />
        <asp:ListBox runat="server" ID="cmbGenero" CssClass="text form-control text-right" Enabled="true" Font-Size="12px">
            <asp:ListItem Text="Hombre" />
            <asp:ListItem Text="Mujer" />
        </asp:ListBox>

        <asp:Label ID="Label5" Font-Size="Medium" Text="Estado:" runat="server" />
        <asp:ListBox runat="server" ID="cmbEstado" CssClass="text form-control text-right" Enabled="true" Font-Size="12px">
            <asp:ListItem Text="Activo" />
            <asp:ListItem Text="Inactivo" />
        </asp:ListBox>
        <br />

        <!-- BOTONES -->
        <asp:Button ID="btnNuevo" Text="Nuevo" runat="server" OnClick="btnNuevo_Click" CssClass="btn" BackColor="Gray" ForeColor="White" />
        <asp:Button ID="btnFinalizar" Text="Finalizar" runat="server" CssClass="btn" OnClick="btnFinalizar_Click" BackColor="Gray" ForeColor="White" />


    </form>

</body>
</html>

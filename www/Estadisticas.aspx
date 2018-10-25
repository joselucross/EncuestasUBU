﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="www.Estadisticas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Titulo" runat="server" Text="Label"></asp:Label>
            <asp:Image ID="IME" runat="server" src ="../../img/ENFADADO.png"/>
            <asp:Label ID="PME" runat="server" Text="Label"></asp:Label>
            <asp:Image ID="IE" runat="server" src ="../../img/NEUTRAL.png" />
            <asp:Label ID="PE" runat="server" Text="Label"></asp:Label>
            <asp:Image ID="IC" runat="server" src ="../../img/SATISFECHO.png" />
            <asp:Label ID="PC" runat="server" Text="Label"></asp:Label>
            <asp:Image ID="IMC" runat="server" src ="../../img/CONTENTO.png" />
            <asp:Label ID="PMC" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Comentario" runat="server" Text="Comentarios:"></asp:Label>
            <asp:Table ID="TC" runat="server">
            </asp:Table>
            <asp:Button ID="BA" runat="server" Text="Atras" OnClick="BA_Click" />
            <asp:Button ID="BCS" runat="server" Text="Cerrar Sesión" OnClick="BCS_Click" />
        </div>
    </form>
</body>
</html>

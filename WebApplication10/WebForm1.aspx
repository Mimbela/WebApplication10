<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAscendente" runat="server" Text="Ascendente" OnClick="btnAscendente_Click" />
            <asp:Button ID="btnSeleccionA" runat="server" Text="Seleccion A" OnClick="btnSeleccionA_Click" />
            <asp:Button ID="btnSeleccionNumero" runat="server" Text="Selección Número" OnClick="btnSeleccionNumero_Click" />


        </div>
    </form>
</body>
</html>

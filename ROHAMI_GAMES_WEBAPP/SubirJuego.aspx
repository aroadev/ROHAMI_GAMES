<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubirJuego.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.SubirJuego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <title></title>
     <!-- Latest compiled and minified CSS -->
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="CssStyles/loginCss.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
</head>
<body class="bg-warning">
    <form id="form1" runat="server">
        <div class="container-fluid text-center ">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <asp:FileUpload ID="fuImagen" runat="server" CssClass="form-control"/>
                    <br />
                    <label> Nombre Juego:  </label>
                    <br />
                    <asp:TextBox runat="server" ID="txtNombreJuego" CssClass="form-control"></asp:TextBox>
                    <br />
                    <label> Empresa </label>
                    <br />
                    <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control"></asp:TextBox>
                    <br />
                    <label> Plataforma </label>
                    <br />
                    <asp:DropDownList runat="server" ID="ddlPlataforma">
                        <asp:ListItem> Playstation 4 </asp:ListItem>
                        <asp:ListItem> Xbox One </asp:ListItem>
                        <asp:ListItem> Nintendo Switch </asp:ListItem>
                        <asp:ListItem> PC </asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <label> Clasificacion </label>
                    <br />
                    <asp:DropDownList runat="server" ID="ddlClasificacion" >
                        <asp:ListItem> Earlychildhood </asp:ListItem>
                        <asp:ListItem> Everyone </asp:ListItem>
                        <asp:ListItem> 10+ </asp:ListItem>
                        <asp:ListItem> Teen </asp:ListItem>
                        <asp:ListItem> Mature </asp:ListItem>
                        <asp:ListItem> Adult Only </asp:ListItem>
                        <asp:ListItem> Clasificacion Pendiente </asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <label> Precio </label>
                    <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Button runat="server" ID="btnSubir" CssClass="btn btn-primary" OnClick="btnSubir_Click" Text="Subir"/>
                    <asp:Button runat="server" ID="btnExit" CssClass="btn btn-danger" OnClick="btnExit_Click" Text="Salir" />
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</body>
</html>

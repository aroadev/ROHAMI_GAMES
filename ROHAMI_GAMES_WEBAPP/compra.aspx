<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compra.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.compra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1" />

    <title></title>
     <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="CssStyles/mainpage.css" />
  <%--  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />--%>
    <link rel="stylesheet" href="CssStyles/loginCss.css" />
    <%--<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous">--%>


    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
    <!-- Google Fonts -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap">
    <!-- Bootstrap core CSS -->

    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/css/bootstrap.min.css" rel="stylesheet">
    <!-- Material Design Bootstrap -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.14.0/css/mdb.min.css" rel="stylesheet">
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
</head>
<body class="bg-dark">
    <form id="form1" runat="server">
        <nav class="navbar-nav navbar-expand-xl navbar-dark sticky-top" style="background-color: #0d0a0b">
            <img src="images/logo.png" class="navbar-brand" style="width: 10%"/>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto nav-fill">
                    <li class="nav-item active">
                        <a class="nav-link" href="#HOME" >HOME</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#MISJUEGOS">MIS JUEGOS</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#CATALOGO">CATALOGO</a> 
                    </li>
                </ul>
                <form class="form-inline my-2 my-lg-0">
                    <div class="dropdown show">
                      <a class="btn btn-dark dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                          <i class="fas fa-user"></i>
                          <asp:Label runat="server" ID="lblUsuario" ></asp:Label>
                      </a>
                      <div class="dropdown-menu bg-dark" aria-labelledby="dropdownMenuLink">
                        <a class="dropdown-item text-white" href="#">Mi Cuenta</a>
                        <a class="dropdown-item text-white" href="Login.aspx">Iniciar Sesión</a> 
                      </div>
                    </div>
                </form>
            </div>           
         </nav>
        <div class="container-fluid align-content-center">
            <div class="row">
                <div class="col-md-6">
                    <%--<img src="images/games/call-of-duty-modern-warfare-2019-1.jpg" class="rounded float-left" width="60%"/>--%>
                </div>
                <div class="col-md-6 text-center">
                    <asp:Label runat="server" ID="lblNombreJuego" CssClass="h1 text-white text-center"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblEmpresa" CssClass="h4 text-white"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblPlataforma" CssClass="h4 text-white"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblClasificacion" CssClass="h4 text-white"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblPrecio" CssClass="h4 text-white"></asp:Label>
                    <br />
                    <asp:DropDownList runat="server" ID="ddlTiposPago">

                    </asp:DropDownList>
                    <br />
                    <asp:Button runat="server" ID="btnComprar" CssClass="btn btn-primary" Text="Comprar" OnClick="btnComprar_Click"/>
                    <br />
                </div>
            </div>
            >
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.Catalogo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <!-- Conectamos todas las dependencias de Bootstrap 4.4 -->
    <link rel="stylesheet" href="CssStyles/loginCss.css" />
    <link rel="stylesheet" href="CssStyles/animation.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.14.1/css/mdb.min.css" rel="stylesheet" /> 
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous" />
    <!-- Conectamos todos los Scripts Necesarios para Bootstrap 4.4 -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar-nav navbar-expand-xl navbar-dark sticky-top" style="background-color: #0d0a0b">
            <img src="images/logo.png" class="navbar-brand" style="width: 10%"/>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto nav-fill">
                    <li class="nav-item">
                        <a class="nav-link" href="#HOME" >HOME</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#MISJUEGOS">MIS JUEGOS</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="#CATALOGO">CATALOGO</a> 
                    </li>
                </ul>
               <%-- <form class="form-inline my-2 my-lg-0">
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
                </form>--%>
            </div>           
        </nav>
        <br />
        <center>
            <asp:GridView runat="server" ID="gvJuegos" DataKeyNames="ID_JUEGO" AutoGenerateColumns="false" CssClass="justify-content-center text-center" Width="652px">
                        <Columns>
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblNombre" Text='<%# Eval("NOMBRE") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Empresa">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblEmpresa" Text='<%# Eval("EMPRESA") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblEmpresa" Text='<%# Eval("PRECIO") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="btnComprar" Text="¡Lo quiero!" OnClick="btnComprar_Click" CssClass="btn btn-link"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
        </center>
    </form>
</body>
</html>

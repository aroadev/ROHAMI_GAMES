<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.AppCode.main" %>
<%--USING BOOTSTRAP 4 PAGE FORMAT--%>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <title></title>
    <link rel="stylesheet" href="CssStyles/loginCss.css" />
    <link rel="stylesheet" href="CssStyles/animation.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.14.1/css/mdb.min.css" rel="stylesheet"> 
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</head>
<body class="bg-dark">
    <form id="form1" runat="server">
        <%--BARRA DE NAVEGACION--%>
         <nav class="navbar fixed-top navbar-expand-lg black scrolling-navbar" style="background-color: #0d0a0b">
            <img src="images/logo.png" class="navbar-brand" style="width: 10%"/>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto nav-fill text-white">
                    <li class="nav-item active">
                        <a class="nav-link active text-white" href="#HOME" >HOME</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-white" href="#MISJUEGOS">MIS JUEGOS</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-white" href="Catalogo.aspx">CATALOGO</a> 
                    </li>
                </ul>
                <form class="form-inline my-2 my-lg-0">
                    <div class="dropdown show">
                      <a class="btn btn-dark dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                          <i class="fas fa-user"></i>
                          <asp:Label runat="server" ID="lblUsuario" ></asp:Label>
                      </a>
                      <div class="dropdown-menu bg-dark" aria-labelledby="dropdownMenuLink">
                        <a class="dropdown-item text-white" href="ConfiguracionCuenta.aspx">Mi Cuenta</a>
                        <asp:LinkButton CssClass="dropdown-item text-white" ID="lkbIniciarSesion" runat="server" Text="Iniciar Sesión" Visible="true" OnClick="lkbIniciarSesion_Click"></asp:LinkButton>
                        <asp:LinkButton CssClass="dropdown-item text-white" ID="lkbCerrarSesion" runat="server" Text="Cerrar Sesión" Visible="false" OnClick="lkbCerrarSesion_Click"></asp:LinkButton>
                        <asp:LinkButton CssClass="dropdown-item text-white" ID="lkbRegistrar" runat="server" Text="Registrar" Visible="True" OnClick="lkbRegistrar_Click"></asp:LinkButton>
                        <asp:LinkButton CssClass="dropdown-item text-white" ID="lkbAgregarJuego" runat="server" Text="Añadir Juego" Visible="false" OnClick="lkbAgregarJuego_Click"></asp:LinkButton>
                      </div>
                      </div>
                    </div>
                </form>
            </div>           
         </nav>
        <%--CONTENIDO DE LA PÁGINA--%>
         <div class="container-fluid grey darken-2">
             <%--CARRUSEL DE FOTOS--%>
            <div class="row">
                 <div class="col-sm-12">
                      <div id="demo" class="carousel slide align-content-center text-center" data-ride="carousel">
                  <ul class="carousel-indicators">
                    <li data-target="#demo" data-slide-to="0" class="active"></li>
                    <li data-target="#demo" data-slide-to="1"></li>
                    <li data-target="#demo" data-slide-to="2"></li>
                  </ul>
                <div class="carousel-inner">
                    <div class="carousel-item active" data-ride="Doom">
                        <img src="images/games/doom_eternal.jpg" alt="Doom Eternal"/>
                        <div class="carousel-caption d-none d-md-block">
                            <h5>Doom: Eternal</h5>
                            <p>Los ejércitos del infierno han invadido la Tierra. Ponte en la piel del Slayer en una épica campaña para un jugador y cruza dimensiones para detener la destrucción definitiva de la humanidad.</p>
                        </div>
                    </div>
                    <div class="carousel-item" data-ride="portal">
                        <img src="images/games/portal_2_fhd.jpg" />
                        <div class="carousel-caption d-none d-md-block">
                            <h5>Portal 2</h5>
                            <p>¡La "Iniciativa de Prueba Perpetua" ha sido ampliada, permitiéndote ahora diseñar puzles cooperativos para ti y tus amigos! </p>
                        </div>
                    </div>
                    <div class="carousel-item">
                        <img src="images/games/r6s.jpg" />
                        <div class="carousel-caption d-none d-md-block">
                            <h5>Rainbow Six: Siege</h5>
                            <p>Participa en intensos combates cuerpo a cuerpo en una variedad de mapas de todo el mundo. No hay dos iguales, por lo que deberá adaptar su estrategia, tácticas y elegir sus operadores en consecuencia.</p>
                        </div>
                    </div>
                </div>
                <a class="carousel-control-prev" href="#demo" data-slide="prev">
                    <span class="carousel-control-prev-icon"></span>
                  </a>
                  <a class="carousel-control-next" href="#demo" data-slide="next">
                    <span class="carousel-control-next-icon"></span>
                  </a>
            </div>
                 </div>
             </div>      
<%--           CONTENIDO CENTRAL--%>
            <div class="row">
                <div class="col-sm-6 text-center grey darken-3 text-white">
                    <br />
                    <h1>JUEGOS EN OFERTA</h1>
                    <br />
                    <img src="images/games/call-of-duty-modern-warfare-2019-1.jpg" width="720px" />
                    <br />
                    <h2>Call Of Duty: Modern Warfare </h2>
                    <h3>$820 MX</h3>
                    <br />
                    <button class="btn btn-primary button hoverable"><span><a class="text-light" href="compra.aspx">COMPRAR</a></span></button>
                    <br />
                </div>
                <div class="col-sm-6 text-center grey darken-3 text-white">
                    <br />
                    <h1>ACCESORIOS EN OFERTA</h1>
                    <br />
                    <img src="images/games/8372854_1007.jpg" width="400px" />
                    <br />
                    <h2>HyperX Cloud II</h2>
                    <h3>$1861 MX</h3>
                    <br />
                    <button class="btn btn-primary button hoverable"><span><a class="text-light" href="">COMPRAR</a></span></button>
                    <br />
                </div>
            </div>
             <%--VIDEO RESPONSIVE--%>
            <div class="embed-responsive embed-responsive-16by9">
               <iframe class="embed-responsive-item" src="https://www.youtube.com/embed/ANupm_qZBYo " allowfullscreen></iframe>
                <br />
                <br />
            </div>
        </div>
        <!-- Footer -->
         <footer class="page-footer font-small black">

          <!-- Copyright -->
          <div class="footer-copyright text-center py-3">© 2020 Copyright:
            <a href="https://mdbootstrap.com/"> Miguel Salinas Barbeyto - Hamed Manrique Retis- Luis Roberto Santiago Aguirre</a>
          </div>
          <!-- Copyright -->

        </footer>
    </form>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</body>
</html>

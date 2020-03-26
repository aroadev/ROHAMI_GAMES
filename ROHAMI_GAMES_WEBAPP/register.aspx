<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.App_Code.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang ="en">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

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
<body>
     <form id="form1" runat="server">     
       <div class="sidenav">
         <div class="login-main-text">
            <img src="images/logo_Access.png" width="110%" />
         </div>
      </div>
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               <form>
                  <div class="form-group">
                     <label>Nombre</label>
                      <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"/>
                  </div>
                  <div class="form-group">
                     <label>Apellido</label>
                      <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                  </div>
                   <div class="form-group">
                     <label>Username / Nickname</label>
                      <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control" />
                  </div>
                  <div class="form-group">
                     <label>Correo</label>
                      <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" />
                  </div>
                  <div class="form-group">
                     <label>Contraseña</label>
                      <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                  </div>
                  <div class="form-group">
                     <label>Confirmar Contraseña</label>
                      <asp:TextBox runat="server" ID="txtConfirm" TextMode="Password" CssClass="form-control" />
                  </div>
                  <div class="form-group">
                     <label>Telefono (Opcional)</label>
                      <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" />
                  </div>
                    <asp:Button runat="server" ID="btnRegistrar" CssClass ="btn btn-secondary" Text="Registrar" OnClick="btnRegistrar_Click"/>
                    <button type="submit" class="btn btn-black "><a href="Login.aspx" class="text-white">ACCEDER</a></button>
               </form>
            </div>
         </div>
      </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.Login" %>

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
<body class="Login">
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
                     <label>Usuario</label>
                      <asp:TextBox runat="server" ID="txtUsuarioLogin" CssClass="form-control"/>
                     <%--<input type="text" class="form-control" placeholder="User Name">--%>
                  </div>
                  <div class="form-group">
                     <label>Contraseña</label>
                      <asp:TextBox runat="server" ID="txtPasswordLogin" TextMode="Password" CssClass="form-control" />
                     <%--<input type="password" class="form-control" placeholder="Password">--%>
                  </div>
                   <asp:Button runat="server" ID="btnAcceder" CssClass="btn btn-black" Text="Acceder" OnClick="btnAcceder_Click" />
                  <%--<button type="submit" class="btn btn-black">Login</button>--%>
                   <asp:Button runat="server" ID="btnRegistrar" CssClass ="btn btn-secondary" Text="Registrar" OnClick="btnRegistrar_Click"/>
                  <%--<button type="submit" class="btn btn-secondary" >Register</button>--%>
               </form>
            </div>
         </div>
      </div>
    </form>
</body>
</html>

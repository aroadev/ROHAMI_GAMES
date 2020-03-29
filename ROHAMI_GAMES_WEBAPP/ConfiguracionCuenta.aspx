<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfiguracionCuenta.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.ConfiguracionCuenta" %>

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
         <div class="col-md-6">
            <div>
                <br />
                <br />
                <br />
                
               <form>
                  <div class="form-group">
                     <label>Usuario</label>
                      <asp:TextBox runat="server" ID="txtNombreUsuario" CssClass="form-control"/>
                     <%--<input type="text" class="form-control" placeholder="User Name">--%>
                  </div>
                  <div class="form-group">
                     <label>Correo</label>
                      <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" />
                     <%--<input type="password" class="form-control" placeholder="Password">--%>
                  </div>
                  <div class="form-group">
                     <label>Nombre Real</label>
                      <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                     <%--<input type="password" class="form-control" placeholder="Password">--%>
                  </div>
                  <div class="form-group">
                      <label>Apellido Real</label>
                      <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                     <%--<input type="password" class="form-control" placeholder="Password">--%>
                  </div>
                   <div class="form-group">
                      <label>Cambio de Contraseña</label>
                       <br />
                      <asp:Button runat="server" ID="btnCambiarContraseña" CssClass="btn btn-info" Text="Cambiar Contraseña" OnClick="btnCambiarContraseña_Click"/>
                     <%--<input type="password" class="form-control" placeholder="Password">--%>
                  </div>
                   <%--Contenedor del Cambio de Contraseña--%>
                   <div class="form-group"> 
                       <asp:Label runat="server" ID="lblTexto1" CssClass="label" Text="Contraseña Actual" Visible="false"></asp:Label>
                       <asp:TextBox runat="server" ID="txtPasswordActual" CssClass="form-control" Visible="false"></asp:TextBox>
                       <asp:Label runat="server" ID="lblTexto2" CssClass="label" Text="Contraseña Nueva" Visible="false"></asp:Label>
                       <asp:TextBox runat="server" ID="txtNuevaPassword" CssClass="form-control" TextMode="Password" Visible="false"></asp:TextBox >
                       <asp:Label runat="server" ID="lblTexto3" CssClass="label" Text="Confirmar contraseña nueva" Visible="false"></asp:Label>
                       <asp:TextBox runat="server" ID="txtConfirmacion" CssClass="form-control" Visible="false"></asp:TextBox>
                       <br />
                       <asp:Button runat="server" ID="btnCambiarPassword" CssClass="btn btn-danger" Text="Cambiar Contraseña" Visible="false" OnClick="btnCambiarPassword_Click"/>
                       <br />
                       <asp:Label runat="server" ID="lblSuccess" CssClass="alert alert-success" Text="Contraseña actualizada con éxico." Visible="false"></asp:Label>
                       <asp:Label runat="server" ID="lblPasswordAdv1" CssClass="alert alert-warning" Text="Las contraseñas no coinciden." Visible="false"></asp:Label>
                       <asp:Label runat="server" ID="lblPasswordAdv2" CssClass="alert alert-warning" Text="¡La contraseña nueva y la actual son la misma!" Visible="false"></asp:Label>
                       <asp:Label runat="server" ID="lblPasswordAdv3" CssClass="alert alert-danger" Text="Contraseña menor de 8 digitos." Visible="false"></asp:Label>
                       <asp:Label runat="server" ID="lblPasswordAdv4" CssClass="alert alert-warning" Text="La contraseña actual es incorrecta" Visible="false"></asp:Label>
                     <%--<input type="password" class="form-control" placeholder="Password">--%>
                  </div>
                   <div class="form-group">
                       <button class="btn btn-secondary"><a href="DatosPago.aspx" class="text-white">Agregar Un Método de Pago</a></button>
                   </div>
                   <asp:Label runat="server" ID="lblSuccesUpdate" CssClass="alert alert-success" Text="Actualizado con exito"></asp:Label>
                   <asp:Button runat="server" ID="btnActualizar" CssClass="btn btn-black" Text="Actualizar Datos" OnClick="btnActualizar_Click"/>
                   <asp:Button runat="server" ID="btnCancelar" CssClass ="btn btn-secondary" Text="Cancelar"/>
               </form>
            </div>
         </div>
      </div>
    </form>
</body>
</html>

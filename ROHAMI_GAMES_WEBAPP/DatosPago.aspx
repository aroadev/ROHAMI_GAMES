<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosPago.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.Pagar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <title>

    </title>

    <link rel="stylesheet" href="CssStyles/loginCss.css" />
    <link rel="stylesheet" href="CssStyles/animation.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.14.1/css/mdb.min.css" rel="stylesheet" /> 
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous" />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg black scrolling-navbar align-content-center justify-content-center text-center"> 
            <a class="navbar-brand" > DATOS DE PAGO </a>
            <div class="collapse navbar-collapse">
                <ul class="nav justify-content-center nav-pills">
                    <li class="nav-item">
                        <a class="nav-link active text-white"> Regresar a la Tienda </a>
                    </li>
                </ul>
            </div>
        </nav>
    <div class="row mb-4">
        <div class="col-lg-8 mx-auto text-center">
            <h1 class="display-4">ROHAMI GAMES PAYMENTS</h1>
        </div>
    </div> <!-- End -->
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card ">
                <div class="card-header">
                    <div class="bg-white shadow-sm pt-4 pl-2 pr-2 pb-2">
                        <!-- Credit card form tabs -->
                        <ul role="tablist" class="nav bg-light nav-pills rounded nav-fill mb-3">
                            <li class="nav-item"> <a data-toggle="pill" href="#credit-card" class="nav-link active "> <i class="fas fa-credit-card mr-2"></i> Credit Card </a> </li>
                        </ul>
                    </div> <!-- End -->
                    <!-- Credit card form content -->
                    <div class="tab-content">
                        <!-- credit card info-->
                        <div id="credit-card" class="tab-pane fade show active pt-3">
                            <form role="form">
                                <div class="form-group"> <label for="username">
                                        <h6>Dueño de la Tarjeta</h6>
                                    </label> <asp:TextBox runat="server" ID="txtNombrePropietario" CssClass="form-control"></asp:TextBox> </div>
                                <div class="form-group"> <label for="cardNumber">
                                        <h6>Numero de Tarjeta</h6>
                                    </label>
                                    <div class="input-group"> <asp:TextBox runat="server" ID="txtNumeroTarjeta" CssClass="form-control"></asp:TextBox>
                                        <div class="input-group-append"> <span class="input-group-text text-muted"> <i class="fab fa-cc-visa mx-1"></i> <i class="fab fa-cc-mastercard mx-1"></i> <i class="fab fa-cc-amex mx-1"></i> </span> </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-8">
                                        <div class="form-group"> <label><span class="hidden-xs">
                                                    <h6>Expiration Date</h6>
                                                </span></label>
                                            <h6> Mes </h6> 
                                            <asp:DropDownList runat="server" ID="ddlDia" ></asp:DropDownList>
                                            <h6> Año </h6> 
                                            <asp:DropDownList runat="server" ID="ddlMes"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group mb-4"> <label data-toggle="tooltip" title="Three digit CV code on the back of your card">
                                                <h6>CVV <i class="fa fa-question-circle d-inline"></i></h6>
                                            </label> <asp:TextBox runat="server" ID="txtCVV" CssClass="form-control" MaxLength="3"></asp:TextBox> </div>
                                    </div>
                                </div>
                                <div class="card-footer"> <asp:Button runat="server" ID="btnAgregarMetodo" OnClick="btnAgregarMetodo_Click" CssClass="subscribe btn btn-primary btn-block shadow-sm" Text="Agregar Pago" /> </div>
                                <asp:Label runat="server" ID="lblSucces" CssClass="alert alert-success" Text="¡Método agregado de pago agregado!" Visible="false"></asp:Label>
                            </form>
                        </div>
                    </div> <!-- Fin -->
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="ROHAMI_GAMES_WEBAPP.Catalogo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="gvJuegos">
                <Columns>
                    <asp:TemplateField>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
         </div>
    </form>
</body>
</html>

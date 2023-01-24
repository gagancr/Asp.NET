<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="SampleWebApp.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <h1 class ="h1 text-danger">Product DataBase</h1>
    <hr />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                <asp:ListBox ID="lstProducts" CssClass="form-control" runat="server" Height="386px" Width="213px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="True">
                    </asp:ListBox>


                </div>
                <div class="col-md-7">
                    <h2>
                        Details of the Product
                    </h2>
                    <div class="row">

                        <div class="col-md-6">
                            <asp:Image ID="imgPic" Height="253px" runat="server" Width="255px" />

                        </div>
                        <div class="col-md-4">
                            <p>Id: <asp:TextBox CssClass="form-control" runat="server" ID="txtId"/></p>
                            <p>Name: <asp:TextBox CssClass="form-control" runat="server" ID="txtName"/></p>
                            <p>Price: <asp:TextBox CssClass="form-control" runat="server" ID="txtPrice"/></p>
                            <p>Quantity: 
                                <asp:DropDownList CssClass="form-control" ID="dpQuantity" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList>
                            </p>

                        </div>
                       <div class="col-md-1 align-items-center" >
                            <button runat="server" onserverclick="btnEdit_Click" class="btn btn-info m-2" >
                                <i class="fa fa-pencil"></i>
                            </button>
                            <button runat="server" onserverclick="btnDelete_Click" class="btn btn-danger m-2">
                                <i class="fa fa-trash"></i>
                            </button>
                             <button runat="server"  onserverclick="btnAdd_Click" class="btn btn-primary m-2">
                                <i class="fa fa-plus-circle"></i>
                            </button>
                        </div>



                    </div>

                            

                </div>
            </div>
        </div>
    </form>
</body>
</html>

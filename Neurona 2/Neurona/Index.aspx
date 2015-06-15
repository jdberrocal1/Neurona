<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Neurona.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="/Content/Site.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="/Scripts/jquery-2.1.4.js"></script>
<script src="//code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
    
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="row">
                <div class="col-md-1">
                    <img alt="Brand" src="../Images/neuron.png" />
                </div>
                <div class="col-md-3" >
                    <h3>Neurotron</h3>
                </div>
                
            </div>
        </div>
    </div>
    <br />
    <div class="container" id="body">
        <div class="row">
            <div class="col-md-12">
                <form id="form1" runat="server">
                   <div class="row">
                       
                        <div class="col-md-6">
                            

                            <div class="form-group">
                                Select an Image File
                                <br />
                                <input id="image" name="image" runat="server" size="40" style="z-index: 105; left: 36px; width: 360px; top: 29px; height: 22px" type="file" />
                                <br />
                                <asp:Image ID="img" runat="server" ImageUrl="~/Images/bullet.png"/>
                            </div>

                            Please enter a learning factor
                            <div class="form-group">
                                <asp:TextBox ID="learning" runat="server" Text="0,5" class="form-control"></asp:TextBox>
                            </div>
                            <asp:RegularExpressionValidator ID="viewRegularExpressionValidator" runat="server" ValidationExpression="[0].[0-9]{1,50}" ControlToValidate="learning" ErrorMessage="Please Enter numbers only" ForeColor="Red">Please enter a value between 0 and 1</asp:RegularExpressionValidator>
                            

                            
                            <div class="form-group">
                                Please enter Char
                                <asp:TextBox ID="character" runat="server"  class="form-control"></asp:TextBox>
                            </div>
                            
                            

                            <asp:ImageButton ImageUrl="~/Images/go.png" runat="server" Width="70px" OnClick="evaluate" />
                           
                        </div>
                        <div class="col-md-6">
                            Result
                                <br />
                                <h1 class="result"><asp:Literal ID="result" runat="server" /></h1>
                        </div>
                    </div>
                        
                    </div>
                </form>
            </div>
           
        </div> 
    </div> 
    <br /> 
     <div class="navbar navbar-inverse navbar-fixed-bottom">
        <div class="container body-content" id="foo">
            
                <p id="footer">&copy; 2015 - Built by Jorge Rojas and Daniel Berrocal</p>
            
        </div>
    </div>
    
</body>
</html>

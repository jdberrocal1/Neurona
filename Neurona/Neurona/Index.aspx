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
                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Button  ID="b00" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b01" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b02" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b03" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b04" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>
                            
                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Button  ID="b10" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b11" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b12" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b13" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b14" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Button  ID="b20" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b21" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b22" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b23" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b24" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Button  ID="b30" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b31" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b32" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b33" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b34" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Button  ID="b40" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b41" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b42" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b43" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button  ID="b44" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                        </div>
                        <div class="col-md-6">
                            Please enter a learning factor
                            <div class="form-group">
                                <asp:TextBox ID="learning" runat="server" Text="0.5" class="form-control"></asp:TextBox>
                            </div>
                            <asp:RegularExpressionValidator ID="viewRegularExpressionValidator" runat="server" ValidationExpression="[0].[0-9]{1,50}" ControlToValidate="learning" ErrorMessage="Please Enter numbers only" ForeColor="Red">Please enter a value between 0 and 1</asp:RegularExpressionValidator>
                            <br />
                            <asp:ImageButton ImageUrl="~/Images/go.png" runat="server" Width="70px" OnClick="evaluate" />
                            <br />
                            <br />
                            <div>
                                Result
                                <br />
                                <h1><asp:Literal ID="result" runat="server" /></h1>
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

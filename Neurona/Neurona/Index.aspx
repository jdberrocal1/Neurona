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
                                <div class="col-md-1">
                                    <asp:Button  ID="b00" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b01" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b02" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b03" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b04" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b05" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b06" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b07" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b08" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b09" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>
    
                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b10" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b11" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b12" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b13" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b14" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b15" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b16" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b17" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b18" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b19" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b20" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b21" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b22" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b23" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b24" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b25" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b26" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b27" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b28" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b29" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b30" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b31" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b32" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b33" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b34" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b35" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b36" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b37" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b38" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b39" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b40" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b41" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b42" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b43" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b44" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b45" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b46" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b47" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b48" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b49" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b50" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b51" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b52" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b53" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b54" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b55" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b56" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b57" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b58" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b59" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b60" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b61" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b62" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b63" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b64" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b65" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b66" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b67" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b68" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b69" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b70" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b71" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b72" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b73" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b74" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b75" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b76" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b77" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b78" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b79" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b80" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b81" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b82" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b83" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b84" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b85" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b86" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b87" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b88" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b89" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-1">
                                    <asp:Button  ID="b90" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b91" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b92" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b93" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b94" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b95" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b96" value="0" runat="server" class="btn black" OnClick="paintButton" />
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b97" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b98" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                                <div class="col-md-1">
                                    <asp:Button  ID="b99" value="0" runat="server" class="btn black" OnClick="paintButton"/>
                                </div>
                            </div>  
                        </div>
                        <div class="col-md-6">
                            <asp:CheckBox ID="check" runat="server" Text="Image" />

                            <div class="form-group">
                                Select an Image File
                                <br />
                                <input id="image" name="image" runat="server" size="40" style="z-index: 105; left: 36px; width: 360px; top: 29px; height: 22px" type="file" />
                                <br />
                                <asp:Image ID="img" runat="server" ImageUrl="~/Images/bullet.png"/>
                            </div>

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

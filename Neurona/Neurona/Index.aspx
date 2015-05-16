<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Neurona.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="/Content/Site.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="row">
                <div class="col-md-1">
                    <img alt="Brand" src="../Images/neuron.png" />
                </div>
                <div class="col-md-3" >
                    <h3>Neurontron</h3>
                </div>
                
            </div>
        </div>
        
    </div>
    <div class="container" id="body">
        <div class="row">
            <div class="col-md-12">
                <form id="form1" runat="server">
                    
                </form>
            </div>
           
        </div> 
    </div>  
     <div class="navbar navbar-inverse navbar-fixed-bottom">
        <div class="container body-content" id="foo">
            
                <p id="footer">&copy; 2015 - Built by Jorge Rojas and Daniel Berrocal</p>
            
        </div>
    </div>
</body>
</html>

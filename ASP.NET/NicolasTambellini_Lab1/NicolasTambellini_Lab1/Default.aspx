<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NicolasTambellini_Lab1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperater Converter</title>

    <%--Bootstrap and Bootswatch Styling Imports--%>
    <link href="Content/bootswatch/lumen/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/bootstrap.js"></script>

    <%--Native Style Sheet--%>
    <link href="style.css" rel="stylesheet"/>
</head>

<%--Body--%>
<body class="p-2">
    <%--Form--%>
    <form class="mx-2" id="form1" runat="server">
        <%--Header Title--%>
        <div class="container-fluid">
            <h1 class="text-center">Temperature Converter:</h1>
        </div>

      <%--Table--%>
        <asp:Table ID="conversionTable" runat="server">
            <asp:TableRow>
                <%--1 Column with image taking all 7 rows--%>
                <asp:TableCell RowSpan="7">
                    <asp:Image ID="thermometersImage" runat="server" ImageUrl="~/Images/Thermometer.jpg"/>
                </asp:TableCell>

                <asp:TableCell  CssClass="info"> From: </asp:TableCell>
                <asp:TableCell  CssClass="info"> To: </asp:TableCell>
            </asp:TableRow>

            <%--Dropdown list to selecte temperature scale--%>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:DropDownList ID="fromTemperatureDropDownList" runat="server">
                        <asp:ListItem Text="Celsius" Value="Celsius" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Fahrenheit" Value="Fahrenheit"></asp:ListItem>
                        <asp:ListItem Text="Kelvin" Value="Kelvin"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="toTemperatureDropDownList" runat="server">
                        <asp:ListItem Text="Celsius" Value="Celsius"></asp:ListItem>
                        <asp:ListItem Text="Fahrenheit" Value="Fahrenheit" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Kelvin" Value="Kelvin"></asp:ListItem>
                    </asp:DropDownList>
                        
                </asp:TableCell>
            </asp:TableRow>

            <%--Temperature Converting From--%>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label  CssClass="info" ID="inputTemperatureLabel" runat="server" Text="Input Temperature: "></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="inputTemperatureTextBox" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <%--Temperature Converting Too--%>
             <asp:TableRow>
                <asp:TableCell>
                    <asp:Label CssClass="info" ID="outputTemperatureLabel" runat="server" Text="Output Temperature: "></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="outputTemperatureTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <%--Error Message for no entry--%>
            <asp:TableRow>
                 <asp:TableCell ColumnSpan="2">
                    <asp:RequiredFieldValidator class="warning" ID="inputTemperatureRequiredValidator" runat="server" ErrorMessage="Please make sure you enter a numeric value for input temperature" ControlToValidate="inputTemperatureTextBox"></asp:RequiredFieldValidator>
                </asp:TableCell> 
            </asp:TableRow>

            <%--Error Message Invalid Temperature Entry--%>
             <asp:TableRow>
                 <asp:TableCell ColumnSpan="2">
                    <asp:RangeValidator class="warning" ID="RangeValidator1" runat="server" ErrorMessage="Please make sure you have entered a numeric value in the range of -500 to 1,000,000" MaximumValue="1000" MinimumValue="-1000" Type="Double" ControlToValidate="inputTemperatureTextBox"></asp:RangeValidator>
                </asp:TableCell> 
            </asp:TableRow>
            
            <%--Converion and Clear Table Buttons--%>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button CssClass="btn-success mr-2" ID="convertButton" OnClick="convertButton_Click" runat="server" Text="Convert"/>
                    <asp:Button CssClass="btn-danger" ID="clearButton" OnClick="clearButton_Click" runat="server" Text="Clear" CausesValidation="false"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>

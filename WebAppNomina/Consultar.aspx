<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="WebAppNomina.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <header>
        <nav>
                    <ul id="menu">
                        <li>Menú</li>
                        <li>Consultar</li>
                        <li><a id="A2" runat="server" href="~/Insertar.aspx">Insertar</a></li>
                        <li><a id="A1" runat="server" href="~/Editar.aspx">Editar</a></li>
                        <li><a id="A3" runat="server" href="~/Eliminar.aspx">Eliminar</a></li>
                        <li><a id="A4" runat="server" href="~/CalcularSueldos.aspx">Calcular Sueldos</a></li>
                    </ul>
                </nav>
    </header>
    <form id="form1" runat="server">
    <div>
        <h1>Consultar Empleados</h1>
        <p>
            <asp:GridView ID="GVDatos" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                    <asp:BoundField DataField="HorasTrabajadas" HeaderText="Horas Trabajadas" />
                    <asp:BoundField DataField="SueldoXHora" HeaderText="Sueldo" />
                </Columns>
            </asp:GridView>  
        </p>
    </div>
    </form>
</body>
</html>

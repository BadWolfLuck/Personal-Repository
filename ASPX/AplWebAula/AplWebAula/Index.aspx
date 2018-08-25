//Criando Site para a aula de WEB(ASPX).
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AplWebAula.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NO PAIN NO GAIN</title>
    <link href="App_Themes/CSS/estilos.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: 50px;
            color: #00f;
            background-color: #e6e6e6;
            height: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" method="post" runat="server">

      <table width="1000px" cellpadding="0" cellsparcing="0" border="1">

        <tr>
            <td class="auto-style1" class="clscentro" class="clsmeio" 
                class="clsnegrito" colspan="4" align="center" valign="middle">
                UNIP 2018
            </td>
        </tr>
        <tr height="50px" class="clscentro" >
            <td class="clsnegrito" width ="337.5">Home</td>
            <td class="clsnegrito" width ="337.5">Quem Somos</td>,
            <td class="clsnegrito" width ="337.5">Cadastre-se</td>
            <td class="clsnegrito" width ="337.5" class="auto-style1">Contato</td>
        </tr>
        <tr height="500px" class="clsfundo" >
             <td colspan="4" align="center" valign="middle" class="clscaixaalta">
                 HOME
             </td>
            
        </tr>
        <tr height ="30px" width ="1000" class="clsfundo2">
            <td  colspan="4" align="center" valign="middle">
            &copy Copyright 2018 - Todos os direiros reservados &reg
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmCadastro.aspx.cs" Inherits="WebAulaMasterPage.frmCadastro" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMenu" runat="server">
    <tr>
                        <td width="166px" height="50px">
                            <asp:Button ID="btnIncluir" runat="server" Text="Incluir" CssClass="clsMenu clsNegrito" Width="166px" OnClick="btnIncluir_Click"/>
                        </td>
                        <td width="166px" height="50px">
                            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="clsMenu clsNegrito" Width="166px"/>
                        </td>
                        <td width="166px" height="50px">
                            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="clsMenu clsNegrito" Width="166px"/>
                        </td>
                        <td width="166px" height="50px">
                            <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="clsMenu clsNegrito" Width="166px"/>
                        </td>
                        <td width="166px" height="50px">
                            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="clsMenu clsNegrito" Width="166px"/>
                        </td>
                         <td width="168px" height="50px">
                            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="clsMenu clsNegrito" Width="166px" OnClick="btnVoltar_Click"/>
                        </td>
                    </tr>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphConteudo" runat="server">
    <table width="1000px" cellpadding="0px" cellspacing="0px" border="0">
        <tr>
            <td colspan="2" height="50px" class="clsCentro clsMeio clsNegrito clsMsgErro">
                <asp:Label ID="lblMsgErro" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td width="300px" height="30px" class="clsEsquerda clsMeio clsNegrito">         
                Código:&nbsp;     
            </td>
            <td width="700px" height="30px" class="clsEsquerda clsMeio clsNegrito">
                <asp:TextBox ID="txtCodigo" runat="server" Width="100px" MaxLenght="11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="300px" height="30px" class="clsEsquerda clsMeio clsNegrito">   
                Nome:&nbsp;           
            </td>
            <td width="700px" height="30px" class="clsEsquerda clsMeio clsNegrito">
                <asp:TextBox ID="txtNome" runat="server" Width="100px" MaxLenght="11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="300px" height="30px" class="clsEsquerda clsMeio clsNegrito">   
                E-Mail:&nbsp;           
            </td>
            <td width="700px" height="30px" class="clsEsquerda clsMeio clsNegrito">
                <asp:TextBox ID="txtEmail" runat="server" Width="100px" MaxLenght="11"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="300px" height="30px" class="clsEsquerda clsMeio clsNegrito">   
                Usuário:&nbsp;           
            </td>
            <td width="700px" height="30px" class="clsEsquerda clsMeio clsNegrito">
                <asp:TextBox ID="txtUsuario" runat="server" Width="100px" MaxLenght="11"></asp:TextBox>
            </td>
            <tr>
            <td width="300px" height="30px" class="clsEsquerda clsMeio clsNegrito">   
                Senha:&nbsp;           
            </td>
            <td width="700px" height="30px" class="clsEsquerda clsMeio clsNegrito">
                <asp:TextBox ID="txtSenha" runat="server" Width="100px" MaxLenght="11"></asp:TextBox>
            </td>
        </tr>
        </tr>
    </table>
</asp:Content>


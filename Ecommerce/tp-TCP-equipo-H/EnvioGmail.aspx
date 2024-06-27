<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EnvioGmail.aspx.cs" Inherits="tp_TCP_equipo_H.EnvioGmail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .contenedor3 {
    width: 100%;
    display: flex;
    align-content: center;
    justify-content: center;
    margin-bottom: 40px; 
}

.contenedor3 > h1 {
    align-content: center;
}

.form-contenedor3 {
    width: 100%;
    max-width: 450px;
    background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%);
    border-radius: 15px;
    color: white;
    padding: 50px 60px 70px;
}



.contenedor, .contenedor2 {
    width: 100%;
    display: flex;
    align-content: center;
    justify-content: center;
    margin-bottom: 50px; 
}

.contenedor > h1, .contenedor2 > h1 {
    align-content: center;
}

.form-contenedor, .form-contenedor2 {
    width: 100%;
    max-width: 450px;
    background: linear-gradient(-225deg, #473B7B 0%, #3584A7 51%, #30D2BE 100%);
    border-radius: 15px;
    color: white;
    padding: 50px 60px 70px;
}

.mb-3 {
    margin-bottom: 1rem;
}

.form-label {
    margin-bottom: 0.5rem;
}

.form-control {
    width: 100%;
    padding: 0.5rem;
    font-size: 1rem;
    border: 1px solid #ced4da;
    border-radius: 0.25rem;
}

.btn {
    display: inline-block;
    font-weight: 400;
    color: #212529;
    text-align: center;
    vertical-align: middle;
    cursor: pointer;
    border: 1px solid transparent;
    padding: 0.375rem 0.75rem;
    font-size: 1rem;
    line-height: 1.5;
    border-radius: 0.25rem;
    transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

.btn-primary {
    color: #fff;
    background-color: #007bff;
    border-color: #007bff;
}

.btn-primary:hover {
    color: #fff;
    background-color: #0056b3;
    border-color: #0056b3;
}
          </style>
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



            <section class="contenedor3">
            <div class="form-contenedor3">
                <h1>envio de gmail</h1>
                <div class="mb-3">
                    <label class="form-label">Gmail</label>
                    <asp:TextBox runat="server" ID="txtGmail" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Asunto</label>
                    <asp:TextBox runat="server" ID="txtAsuntiGmail" placeholder="" CssClass="form-control" />
                </div>
                <div class="mb-3" cssclas="form-floating mb-3">
                    <label class="form-label">Mensaje</label>
                    <asp:TextBox runat="server" ID="txtCuerpo" CssClass="form-control" />
                </div>
                <asp:Button Text="Enviar" runat="server" ID="btnGmailAyuda" onclick="btnGmailAyuda_Click" CssClass="btn btn-primary" />
            </div>
        </section>


</asp:Content>



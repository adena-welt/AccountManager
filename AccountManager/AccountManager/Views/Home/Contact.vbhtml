@Code
    ViewData("Title") = "Contato"
End Code

<head>
    @Styles.Render("~/Content/Styles.css")
</head>

<div class="centered-container">
    <div class="styled-box">
        <h2>@ViewData("Title")</h2>
        <hr />
        <br />

        <address style="font-size: large">
            <strong>Endereço:</strong> Passos, MG 37900-000<br /><br>
            <strong>Telefone:</strong> (35) 99960-3975<br /><br>
            <strong>Email:</strong>   <a href="mailto:vchristina122@gmail.com">vchristina122@gmail.com</a><br />
        </address>
    </div>
</div>

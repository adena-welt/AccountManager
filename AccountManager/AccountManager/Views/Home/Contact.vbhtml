@Code
    ViewData("Title") = "Contato"
End Code

<div style="display: flex; justify-content: center;  margin-top: 30px;">
    <div style="width: 50%; border: 1px solid #ccc; padding: 20px; background-color: #f9f9f9; border-radius: 5px;">
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

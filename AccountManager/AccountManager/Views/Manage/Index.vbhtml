@ModelType IndexViewModel
@Code
    ViewBag.Title = "Gerenciamento"
End Code

<h2>@ViewBag.Title</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Alterar as configurações da sua conta</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Senha:</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Altere sua senha", "ChangePassword")
            Else
                @Html.ActionLink("Create", "SetPassword")
            End If
            ]
        </dd>
        <br>
        <dt>Excluir Conta:</dt>
        <dd>
            @If User.Identity.IsAuthenticated Then
                Using Html.BeginForm("Excluir Conta", "Manage", FormMethod.Post, New With {.id = "deleteAccountForm"})
                    @Html.AntiForgeryToken()
                    @<button type="submit" class="btn btn-danger" onclick="return confirm('Tem certeza de que deseja excluir sua conta? Esta ação é irreversível.');">Excluir</button>
                End Using
            End If
        </dd>
    </dl>
</div>

@ModelType IndexViewModel
@Code
    ViewBag.Title = "Gerenciamento"
End Code

<head>
    @Styles.Render("~/Content/Styles.css")
</head>

<div class="centered-container">
    <div class="styled-box">
        <h2>@ViewBag.Title</h2>

        <p class="text-success">@ViewBag.StatusMessage</p>
        <div>
            <h4>Alterar as configurações da sua conta</h4>
            <hr />
            <dl class="dl-horizontal">
                <dt class="col-md-4">Senha:</dt>
                <dd style="margin-bottom: 10px;">
                    @If Model.HasPassword Then
                    @Html.ActionLink("Alterar sua senha", "ChangePassword", Nothing, New With {.class = "btn btn-primary"})
                    End If
                </dd>
                <br>
                <dt class="col-md-4">Excluir:</dt>
                <dd>
                    @If User.Identity.IsAuthenticated Then
                        Using Html.BeginForm("DeleteAccount", "Manage", FormMethod.Post, New With {.id = "deleteAccountForm"})
                    @Html.AntiForgeryToken()
                    @<button type="submit" class="btn btn-danger" onclick="return confirm('Tem certeza de que deseja excluir sua conta? Esta ação é irreversível.');">Excluir sua conta</button>
                        End Using
                    End If
                </dd>
            </dl>
        </div>
    </div>
</div>
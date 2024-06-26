﻿@ModelType ChangePasswordViewModel
@Code
    ViewBag.Title = "Alterar Senha"
End Code

<head>
    @Styles.Render("~/Content/Styles.css")
</head>

<div class="centered-container">
    <div class="styled-box">
        <h2>@ViewBag.Title</h2>

        @Using Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()

        @<text>
            <h4>Formulário de alteração de senha</h4>
            <hr />
            @Html.ValidationSummary("", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(m) m.OldPassword, New With {.class = "col-md-4 control-label"})
                <div class="col-md-8">
                    @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-4 control-label"})
                <div class="col-md-8">
                    @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-4 control-label"})
                <div class="col-md-8">
                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-4 col-md-8">
                    <input type="submit" value="Alterar senha" class="btn btn-primary" />
                </div>
            </div>
        </text>
        End Using
    </div>
</div>

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section

﻿@ModelType LoginViewModel
@Code
    ViewBag.Title = "Entrar"
End Code

<head>
    @Styles.Render("~/Content/Styles.css")
</head>

<div class="centered-container">
    <div class="styled-box">
        <h2>@ViewBag.Title</h2>
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
            @Html.AntiForgeryToken()
            @<text>
                <h4>Use uma conta local para fazer login</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-3 control-label"})
                    <div class="col-md-9">
                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-3 control-label"})
                    <div class="col-md-9">
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-3 col-md-9">
                        <div class="checkbox">
                            @Html.CheckBoxFor(Function(m) m.RememberMe)
                            @Html.LabelFor(Function(m) m.RememberMe)
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-3 col-md-9">
                        <input type="submit" value="Entrar" class="btn btn-primary" />
                    </div>
                </div>
                <p>
                    @Html.ActionLink("Registrar novo usuário", "Register")
                </p>
            </text>
            End Using
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section

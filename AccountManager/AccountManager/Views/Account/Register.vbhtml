@ModelType RegisterViewModel
@Code
    ViewBag.Title = "Cadastrar"
End Code

<div style="display: flex; justify-content: center; align-items: center; margin-top: 30px;">
    <div style="width: 50%; border: 1px solid #ccc; padding: 20px; background-color: #f9f9f9; border-radius: 5px; ">
        <h2>@ViewBag.Title</h2>
        @Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<text>
            <h4>Crie uma nova conta</h4>
            <hr />
            @Html.ValidationSummary("", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(m) m.FirstName, New With {.class = "control-label col-md-4"})
                <div class="col-md-8">
                    @Html.TextBoxFor(Function(m) m.FirstName, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(m) m.FirstName, "", New With {.class = "text-danger"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.LastName, New With {.class = "control-label col-md-4"})
                <div class="col-md-8">
                    @Html.TextBoxFor(Function(m) m.LastName, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(m) m.LastName, "", New With {.class = "text-danger"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Email, New With {.class = "control-label col-md-4"})
                <div class="col-md-8">
                    @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Password, New With {.class = "control-label col-md-4"})
                <div class="col-md-8">
                    @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "control-label col-md-4"})
                <div class="col-md-8">
                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-4 col-md-8">
                    <input type="submit" class="btn btn-primary" value="Cadastrar" />
                </div>
            </div>
        </text>
        End Using
    </div>
</div>

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section

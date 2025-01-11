$.validator.addMethod("password", function (value, element) {
    return this.optional(element) || /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/.test(value);
});

$.validator.unobtrusive.adapters.addBool("password");


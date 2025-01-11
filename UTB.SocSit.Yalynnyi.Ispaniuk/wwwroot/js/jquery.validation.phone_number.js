$.validator.addMethod("phoneNumber", function (value, element) {
    return this.optional(element) || /^\+\d{5,19}$/.test(value);
});

$.validator.unobtrusive.adapters.addBool("phoneNumber");


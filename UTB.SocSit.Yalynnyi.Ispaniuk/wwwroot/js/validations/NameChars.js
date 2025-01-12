// Add custom validation method
$.validator.addMethod('namechars', function (value, element) {
    if (!value || value === '') {
        return true; // Allow empty values if not required
    }
    const regex = /^(?=.*\S)[A-Za-z0-9 ]+$/; // Allow letters, digits, and spaces only
    return regex.test(value);
}, 'Invalid name. It can contain letters, digits, and spaces only.');

// Add adapter for unobtrusive validation
$.validator.unobtrusive.adapters.add('namechars', [], function (options) {
    options.rules['namechars'] = true;
    options.messages['namechars'] = options.message;
});

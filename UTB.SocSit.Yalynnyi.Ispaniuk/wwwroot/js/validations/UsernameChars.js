$.validator.addMethod('usernamechars',
    function (value, element, params) {
        if (!value || value == '')
            return true;

        const regex = /^(?=.*\S)[A-Za-z0-9._]+$/;
        if (regex.test(value)) {
            return true;
        }
        return false;
    });

$.validator.unobtrusive.adapters.add('usernamechars', '',
    function (options) {
        var element = $(options.form).find('#Description')[0];
        options.rules['usernamechars'] = [element, ''];
        options.messages['usernamechars'] = options.message;
    });

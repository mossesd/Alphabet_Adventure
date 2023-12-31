ol().treePath(node)
            };

            Host.instance.showNodeContextMenu(JSON.stringify(args), left, top, elementTop, elementHeight);
        };

        ViewHost.prototype._createLayoutContainer = function () {
            return null;
        };

        ViewHost.prototype.multiSelectionMode = function (value) {
            if (this.control() && !Core.isNullOrUndefined(value)) {
                this.control().multiSelectionCoupleActivation(false);
            }

            return _super.prototype.multiSelectionMode.call(this, value);
        };

        ViewHost.prototype.validateSelection = function (node) {
            var args = {
                path: this.control().treePath(node)
            };

            return Host.instance.validateSelection(JSON.stringify(args));
        };
        return ViewHost;
    })(BaseNavigatorViewHost);
    NavigatorFloatingDialog.ViewHost = ViewHost;
})(NavigatorFloatingDialog || (NavigatorFloatingDialog = {}));
//# sourceMappingURL=NavigatorFloatingDialogViewHost.js.map
       3  ﻿//----------------------------------------------------------
// Copyright (C) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------
var Debug;
(function (Debug) {
    function assertValue(value, message) {
        if (value === null || value === undefined) {
            fail(message);
        }
    }
    Debug.assertValue = assertValue;

    function assert(value, message) {
        if (!value) {
            fail(message);
        }
    }
    Debug.assert = assert;

    function fail(message) {
        try  {
            Host.instance.assertFail(message);
        } catch (ex) {
        }
    }
    Debug.fail = fail;

    function log(message) {
        try  {
            Host.instance.log(message);
        } catch (ex) {
        }
    }
    Debug.log = log;
})(Debug || (Debug = {}));

var Verify;
(function (Verify) {
    function hasValue(value, name) {
        if (value === null || value === undefined) {
            throw "Unexpected null or undefined in: " + name;
        }
    }
    Verify.hasValue = hasValue;

    function isTrue(value, message) {
        if (!value) {
            throw message;
        }
    }
    Verify.isTrue = isTrue;
})(Verify || (Verify = {}));
//# sourceMappingURL=Debug.js.map
 �  ﻿//----------------------------------------------------------
// Copyright (C) Microsoft Corporation. All rights reserved.
//--------------------------------
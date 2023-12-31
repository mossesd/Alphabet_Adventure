l.prototype.showContextMenuOnDescription = function (viewModel, event) {
            var position = Core.getPositionFromEventOrDefault(event, $(event.target).offset());
            Host.getModule(this._hostBaseModuleNames).showContextMenuOnDescription(position.left, position.top);
        };
        QueryGroupViewModel.prototype.showContextMenuOnTitle = function (viewModel, event) {
            var position = Core.getPositionFromEventOrDefault(event, $(event.target).offset());
            Host.getModule(this._hostBaseModuleNames).showContextMenuOnTitle(position.left, position.top);
        };
        QueryGroupViewModel.prototype.updateViewModel = function (viewModel) {
            this.title(viewModel.title);
            this.titleHighlightRanges(viewModel.titleHighlightRanges);
            this.description(viewModel.description);
            this.descriptionHighlightRanges(viewModel.descriptionHighlightRanges);
            this.navigatorViewHost.renderPreview();
        };
        QueryGroupViewModel._templateName = "queryGroupPreviewTemplate";
        QueryGroupViewModel._rootCS = new ClassSelectorBuilder("js-flyout");
        QueryGroupViewModel._navigatorCS = QueryGroupViewModel._rootCS.descendants("js-navigator");
        return QueryGroupViewModel;
    })();
    TaskPaneFlyout.QueryGroupViewModel = QueryGroupViewModel;
})(TaskPaneFlyout || (TaskPaneFlyout = {}));
f  // Copyright (C) Microsoft Corporation. All rights reserved.
var TaskPaneFlyout;
(function (TaskPaneFlyout) {
    var QueryViewModel = (function () {
        function QueryViewModel(hostModuleNames) {
            this.delayedPreview = ko.observable(false);
            this.hasPreview = ko.observable(false);
            this.loadingPreview = ko.observable(false);
            this.numberOfColumnsLabel = ko.observable("");
            this.previewException = ko.observable(null);
            this._hostModuleNames = hostModuleNames;
        }
        Object.defineProperty(QueryViewModel, "templateName", {
            get: function () {
                return QueryViewModel._templateName;
            },
            enumerable: true,
            configurable: true
        });
        QueryViewModel.templateData = function (hostModuleNames) {
            return new QueryViewModel(hostModuleNames);
        };
        QueryViewModel.prototype.afterRender = function () {
            var _this = this;
            var columnsContainer = QueryViewModel._columnsCS.instantiate();
            this._previewHost = new TaskPaneFlyoutPreviewHost(QueryViewModel._previewCS.instantiate(), columnsContainer);
            this._columnListControl = new ColumnListControl(columnsContainer);
            columnsContainer.off("columnClick");
            columnsContainer.on("columnClick", function (event, index, columnElement) {
                _this._onColumnClick(event, index, columnElement);
            });
        };
        QueryViewModel.prototype.getPreferredWidth = function () {
            var previewWidth = 0;
            if (this.loadingPreview()) {
                var resultElement = QueryViewModel._resultCS.instantiate();
                previewWidth = resultElement.outerWidth(true);
            }
            else if (this._previewHost) {
                var previewControl = this._previewHost.control();
                if (previewControl && previewControl.getPreferredWidth) {
                    var previewElement = QueryViewModel._previewCS.instantiate();
                    var previewElementMargin = previewElement.outerWidth(true) - previewElement.width();
                    previewWidth = previewControl.getPreferredWidth() + previewElementMargin;
                }
            }
            return previewWidth;
        };
        QueryViewModel.prototype.isRenderingComplete = function () {
            return !this.delayedPreview() || !this.loadingPreview();
        };
        QueryViewModel.prototype.isSendAFrownButtonVisible = function (previewException) {
            return !previewException.isExpected && Host.getModule(this._hostModuleNames).isSendAFrownSupported();
        };
        QueryViewModel.prototype.resize = function () {
            if (!this.loadingPreview() && this._previewHost) {
                var previewControl = this._previewHost.control();
                if (previewControl && previewControl.resize) {
                    previewControl.resize();
                }
            }
        };
        QueryViewModel.prototype.selectPreviewCell = function (rowIndex, columnIndex) {
            if (this._previewHost && this._previewHost.selectCell) {
                this._previewHost.selectCell(rowIndex, columnIndex);
            }
        };
        QueryViewModel.prototype.sendAFrownForPreviewException = function () {
            Host.getModule(this._hostModuleNames).sendAFrownForPreviewException();
        };
        QueryViewModel.prototype.setColumns = function (listOfColumnHtml, numberOfColumnsLabel) {
            this._columnListControl.setContent(listOfColumnHtml);
            this.numberOfColumnsLabel(numberOfColumnsLabel);
        };
        QueryViewModel.prototype.setPreview = function (previewHtml) {
            if (!Core.isNullOrUndefined(previewHtml)) {
                this.loadingPreview(false);
                this._previewHost.setPreviewContent(previewHtml);
            }
        };
        QueryViewModel.prototype.setPreviewException = function (previewException) {
            if (!Core.isNullOrUndefined(previewException)) {
                this.loadingPreview(false);
                this.hasPreview(false);
                this.previewException(previewException);
            }
        };
        QueryViewModel.prototype.showContextMenuOnPreviewException = function (viewModel, event) {
            var position = Core.getPositionFromEventOrDefault(event, $(event.target).offset());
            Host.getModule(this._hostModuleNames).showContextMenuOnPreviewException(position.left, position.top);
        };
        QueryViewModel.prototype.updateViewModel = function (viewModel) {
            this.delayedPreview(false);
            this._previewHost.setPreviewContent("");
            this.previewException(viewModel.previewException);
            this.hasPreview(viewModel.hasPreview);
            if (viewModel.hasPreview) {
                if (!Core.isNullOrUndefined(viewModel.previewHtml)) {
                    this.setPreview(viewModel.previewHtml);
                }
                else {
                    this.delayedPreview(true);
                    this.loadingPreview(true);
                }
            }
            this.setColumns(viewModel.listOfColumnHtml, viewModel.numberOfColumnsLabel);
        };
        QueryViewModel.prototype._onColumnClick = function (event, index, columnElement) {
            var offset = columnElement.offset();
            Host.getModule(this._hostModuleNames).onColumnClick(index, offset.left, offset.top + columnElement.height());
        };
        QueryViewModel._templateName = "queryPreviewTemplate";
        QueryViewModel._rootCS = new ClassSelectorBuilder("js-flyout");
        QueryViewModel._resultCS = QueryViewModel._rootCS.descendants("js-result");
        QueryViewModel._previewCS = QueryViewModel._resultCS.descendants("js-preview");
        QueryViewModel._columnsCS = QueryViewModel._resultCS.descendants("js-columns");
        return QueryViewModel;
    })();
    TaskPaneFlyout.QueryViewModel = QueryViewModel;
})(TaskPaneFlyout || (TaskPaneFlyout = {}));
�  // Copyright (C) Microsoft Corporation. All rights reserved.
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var TaskPaneFlyout;
(function (TaskPaneFlyout) {
    var NavigatorViewHost = (function (_super) {
        __extends(NavigatorViewHost, _super);
        function NavigatorViewHost(container, parent, host) {
            _super.call(this, container, parent, host);
        }
        NavigatorViewHost.prototype._createLayoutContainer = function () {
            return null;
        };
        return NavigatorViewHost;
    })(Controls.BaseNavigatorViewHost);
    TaskPaneFlyout.NavigatorViewHost = NavigatorViewHost;
})(TaskPaneFlyout || (TaskPaneFlyout = {}));
�(  // Copyright (C) Microsoft Corporation. All rights reserved.
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Controls;
(function (Controls) {
    var _previewContainerCS = new ClassSelectorBuilder("o-group-previewContainer");
    var _headerCS = _previewContainerCS.children("o-group-previewHeader");
    var _previewCS = _previewContainerCS.children("o-group-preview");
    var _unexpectedExceptionGroupCS = _previewCS.descendants("o-group-unexpectedException");
    var _unexpectedExceptionMessageCS = _unexpectedExceptionGroupCS.descendants("role-message");
    var _unexpectedExceptionStackTraceCS = _unexpectedExceptionGroupCS.descendants("role-stackTrace");
    var _titleGroupCS = _headerCS.descendants("o-group-title");
    var _titleCS = _titleGroupCS.descendants("o-content-title");
    var _previewRefreshButtonCS = _headerCS.descendants("role-refreshButton");
    var _stalenessMessageCS = _titleGroupCS.descendants("o-content-stalenessMessage");
    var _dataScrollCS = _previewContainerCS.descendants("builders-dataScrollContainer");
    var _exceptionPreviewCS = new ClassSelectorBuilder("role-exceptionPreview");
    var _previewHeaderHeightWithoutStalenessMessage = 34;
    var _previewHeaderHeightWithStalenessMessage = 54;
    var _roleHidden = "role-hidden";
    var _cancelRefreshButtonClass = "role-cancel";
    var _zoneNames = {
        previewPane: "previewPane",
        previewHeader: "previewHeader",
        previewMain: "previewMain"
    };
    var QueryNavigatorPreviewViewHost = (function (_super) {
        __extends(QueryNavigatorPreviewViewHost, _super);
        function QueryNavigatorPreviewViewHost(parent, navigatorViewHost) {
            _super.call(this, _previewCS.instantiate());
            this._parent = parent;
            this._navigatorViewHost = navigatorViewHost;
            this.previewPrefix("navigatorPreview-");
            this._layoutContainer = new LayoutModel.Container({
                name: _zoneNames.previewMain,
                element: _previewCS.instantiate(),
                scaleMode: LayoutModel.ScaleMode.variable
            });
            this._masterLayoutContainer = new LayoutModel.Container({
                name: _zoneNames.previewPane,
                element: _previewContainerCS.instantiate(),
                scaleMode: LayoutModel.ScaleMode.variable,
                flow: LayoutModel.Dimension.vertical,
                children: [
                    new LayoutModel.Container({
                        name: _zoneNames.previewHeader,
                        element: _headerCS.instantiate(),
                        scaleMode: LayoutModel.ScaleMode.fixed
                    }),
                    this._layoutContainer
                ]
            });
            var previewRefreshButton = _previewRefreshButtonCS.instantiate();
            previewRefreshButton.attr("title", StringResources.navigatorRefreshButtonRefresh);
            var self = this;
            Button.from(previewRefreshButton, {
                click: function () {
                    if ($(this).hasClass(_cancelRefreshButtonClass)) {
                        self._parent.cancelPreviewRefresh();
                    }
                    else {
                        self._parent.startPreviewRefresh();
                    }
                    previewRefreshButton.focus();
                }
            }).disabled(true);
            this._isPreviewDisplayed = false;
        }
        Object.defineProperty(QueryNavigatorPreviewViewHost.prototype, "layoutContainer", {
            get: function () {
                return this._masterLayoutContainer;
            },
            enumerable: true,
            configurable: true
        });
        QueryNavigatorPreviewViewHost.prototype.setPreview = function (preview) {
            if (preview) {
                this.setPreviewContent(preview);
                this._togglePreviewRefreshButtonEnabled(true);
                this._isPreviewDisplayed = true;
            }
            else {
                this.clearPreview(true);
            }
        };
        QueryNavigatorPreviewViewHost.prototype.show = function () {
            this._masterLayoutContainer.setVisible(true, true);
        };
        QueryNavigatorPreviewViewHost.prototype.hide = function () {
            this._masterLayoutContainer.setVisible(false, true);
        };
        QueryNavigatorPreviewViewHost.prototype.showBusy = function () {
            var previewRefreshButton = _previewRefreshButtonCS.instantiate();
            if (!previewRefreshButton.hasClass(_cancelRefreshButtonClass)) {
                previewRefreshButton.addClass(_cancelRefreshButtonClass);
                previewRefreshButton.attr("title", StringResources.navigatorRefreshButtonCancel);
            }
        };
        QueryNavigatorPreviewViewHost.prototype.hideBusy = function () {
            var previewRefreshButton = _previewRefreshButtonCS.instantiate();
            if (previewRefreshButton.hasClass(_cancelRefreshButtonClass)) {
                previewRefreshButton.removeClass(_cancelRefreshButtonClass);
                previewRefreshButton.attr("title", StringResources.navigatorRefreshButtonRefresh);
            }
        };
        QueryNavigatorPreviewViewHost.prototype.displayBlankPreviewMessage = function (previewEnabled) {
            var message;
            if (previewEnabled) {
                message = this._navigatorViewHost.multiSelectionMode()
                    ? StringResources.noItemsSelectedForPreview
                    : StringResources.noItemSelectedForPreview;
            }
            else {
                message = StringResources.previewIsDisabled;
            }
            var div = $("<div class='o-content-previewPlaceHolder'/>").text(message);
            this.setPreviewContent(div[0].outerHTML);
            this._isPreviewDisplayed = false;
        };
        QueryNavigatorPreviewViewHost.prototype.displayEvaluatingMessage = function () {
            var evaluatingDiv = $("<div class='o-content-previewPlaceHolder role-evaluating' />")
                .text(StringResources.endWithEllipsis(StringResources.previewIsEvaluating));
            this.setPreviewContent("<div class='o-content-image role-evaluating' />" + evaluatingDiv[0].outerHTML);
            this._isPreviewDisplayed = false;
            this._togglePreviewRefreshButtonEnabled(true);
        };
        QueryNavigatorPreviewViewHost.prototype.setTitle = function (title) {
            Widgets.SmartTip.from(_titleCS.instantiate()).text(title);
        };
        QueryNavigatorPreviewViewHost.prototype.setFunctionPreviewMessage = function (message) {
            this.setTitle("");
            this.hideStalenessMessage();
            this._togglePreviewRefreshButtonEnabled(false);
            var div = $("<div class='o-content-previewPlaceHolder role-functionPreview'/>")
                .text(message);
            this.setPreviewContent(div[0].outerHTML);
            this._isPreviewDisplayed = true;
        };
        QueryNavigatorPreviewViewHost.prototype.setStalenessMessage = function (stalenessMessage) {
            var stalenessMessageElement = _stalenessMessageCS.instantiate();
            stalenessMessageElement.removeClass(_roleHidden);
            Widgets.SmartTip.from(stalenessMessageElement).text(stalenessMessage);
            this._masterLayoutContainer.getContainerByName(_zoneNames.previewHeader).setFixedHeight(_previewHeaderHeightWithStalenessMessage);
            this._masterLayoutContainer.layout();
        };
        QueryNavigatorPreviewViewHost.prototype.hideStalenessMessage = function () {
            var stalenessMessageElement = _stalenessMessageCS.instantiate();
            stalenessMessageElement.addClass(_roleHidden);
            this._masterLayoutContainer.getContainerByName(_zoneNames.previewHeader).setFixedHeight(_previewHeaderHeightWithoutStalenessMessage);
            this._masterLayoutContainer.layout();
        };
        QueryNavigatorPreviewViewHost.prototype.clearPreview = function (previewEnabled) {
            if (previewEnabled && this._parent.hasActiveQueryNode()) {
                this.setPreviewContent("");
                this._isPreviewDisplayed = false;
            }
            else {
                this.displayBlankPreviewMessage(previewEnabled);
                this.setTitle("");
                this.hideStalenessMessage();
                this._togglePreviewRefreshButtonEnabled(false);
            }
        };
        QueryNavigatorPreviewViewHost.prototype.isExceptionPreviewDisplayed = function () {
            return this._replacementTarget.find(_exceptionPreviewCS.selector).length > 0;
        };
        QueryNavigatorPreviewViewHost.prototype.isPreviewDisplayed = function () {
            return this._isPreviewDisplayed;
        };
        QueryNavigatorPreviewViewHost.prototype._onRenderPreview = function () {
            var unexpectedExceptionElement = _unexpectedExceptionGroupCS.instantiate();
            if (unexpectedExceptionElement.length) {
                var messageElement = _unexpectedExceptionMessageCS.instantiate();
                var stackTraceElement = _unexpectedExceptionStackTraceCS.instantiate();
                Host.instance.onAjaxException(JSON.stringify({
                    exceptionMessage: messageElement.val(),
                    exceptionStackTrace: stackTraceElement.val(),
                    exceptionToString: stackTraceElement.val()
                }));
            }
            _super.prototype._onRenderPreview.call(this);
            _dataScrollCS.instantiate().attr("tabindex", "0");
        };
        QueryNavigatorPreviewViewHost.prototype._togglePreviewRefreshButtonEnabled = function (enabled) {
            Button.from(_previewRefreshButtonCS.instantiate()).disabled(!enabled);
        };
        return QueryNavigatorPreviewViewHost;
    })(Controls.ResultViewHost);
    Controls.QueryNavigatorPreviewViewHost = QueryNavigatorPreviewViewHost;
})(Controls || (Controls = {}));
b  // Copyright (C) Microsoft Corporation. All rights reserved.
var NavigatorFloatingDialog;
(function (NavigatorFloatingDialog) {
    function initialize(dialogControl) {
        NavigatorFloatingDialog.control = dialogControl;
    }
    NavigatorFloatingDialog.initialize = initialize;
    function _typedHost() {
        return Host.instance;
    }
    window.Editor = window.Editor || {};
    Editor.isReady = function Editor$isReady() {
        return ReadyCounter.isReady() &&
            _typedHost().isReady() &&
            !Editor.isBusy() &&
            Core.isAjaxQueueEmpty() &&
            !Core.isPendingPopups();
    };
    Editor.isBusy = function Editor$isBusy() {
        return NavigatorFloatingDialog.control.isBusy();
    };
    $(window).load(function () {
        Core.initialize("/", "My Workspace", 0);
        DynamicHtml.initializePage();
        Accessibility.initialize();
        Theme.initialize();
        _typedHost().onDialogLoaded();
        NavigatorFloatingDialog.control.showDialog();
    });
})(NavigatorFloatingDialog || (NavigatorFloatingDialog = {}));
�b  // Copyright (C) Microsoft Corporation. All rights reserved.
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Controls;
(function (Controls) {
    var _inlineInvocationViewCS = new ClassSelectorBuilder("o-group-inlineInvocation");
    var _invokeButtonCS = _inlineInvocationViewCS.descendants("role-invoke");
    var _clearButtonCS = _inlineInvocationViewCS.descendants("role-clear");
    var _displayOptionsButtonCS = _inlineInvocationViewCS.descendants("js-displayOptions");
    var _displayOptionsDropButtonCS = _displayOptionsButtonCS.children("o-action-dropbutton");
    var _functionParametersContainerCS = _inlineInvocationViewCS.descendants("o-group-functionParameters");
    var _displayFilterContainerCS = _inlineInvocationViewCS.descendants("o-group-displayFilter");
    var _descriptionContainerCS = _inlineInvocationViewCS.descendants("o-group-invocationDescription");
    var _buttonsContainerCS = _inlineInvocationViewCS.descendants("o-group-invocationButtons");
    var _hideOptionalParametersContextClass = "context-hideOptionalParameters";
    var _invocationViewHeight = 200;
    var _zoneNames = {
        invocationView: "invocationView",
        description: " invocationDescription",
        displayFilters: "invocationDisplayFilters",
        parameters: "invocationParameters",
        buttons: "invocationButtons"
    };
    var QueryNavigatorInvocationViewHost = (function () {
        function QueryNavigatorInvocationViewHost(host, showValidationErrorCallback, hideValidationErrorCallback) {
            var _this = this;
            if (showValidationErrorCallback === void 0) { showValidationErrorCallback = null; }
            if (hideValidationErrorCallback === void 0) { hideValidationErrorCallback = null; }
            this._host = host;
            this._showValidationErrorCallback = showValidationErrorCallback;
            this._hideValidationErrorCallback = hideValidationErrorCallback;
            var layoutChildren = [
                new LayoutModel.Container({
                    considerMargin: true,
                    name: _zoneNames.displayFilters,
                    element: _displayFilterContainerCS.instantiate(),
                    scaleMode: LayoutModel.ScaleMode.fixed,
                }),
                new LayoutModel.Container({
                    name: _zoneNames.parameters,
                    element: _functionParametersContainerCS.instantiate(),
                    scaleMode: LayoutModel.ScaleMode.variable,
                })
            ];
            if (_descriptionContainerCS.instantiate().length) {
                layoutChildren.unshift(new LayoutModel.Container({
                    name: _zoneNames.description,
                    element: _descriptionContainerCS.instantiate(),
                    scaleMode: LayoutModel.ScaleMode.fixed,
                }));
            }
            if (_buttonsContainerCS.instantiate().length) {
                layoutChildren.push(new LayoutModel.Container({
                    name: _zoneNames.buttons,
                    element: _buttonsContainerCS.instantiate(),
                    scaleMode: LayoutModel.ScaleMode.fixed,
                }));
            }
            this._masterLayoutContainer = new LayoutModel.Container({
                name: _zoneNames.invocationView,
                element: _inlineInvocationViewCS.instantiate(),
                scaleMode: LayoutModel.ScaleMode.fixed,
                visible: false,
                flow: LayoutModel.Dimension.vertical,
                considerMargin: true,
                children: layoutChildren
            });
            Button.from(_invokeButtonCS.instantiate(), {
                click: function (event) { _this.apply(); }
            });
            Button.from(_clearButtonCS.instantiate(), {
                click: function (event) { _this._host.clearParameters(); }
            });
            Button.from(_displayOptionsButtonCS.selector, {
                click: function (event) {
                    var button = _displayOptionsDropButtonCS.instantiate();
                    var offset = button.offset();
                    var yPos = offset.top + button.height();
                    _this._host.showDisplayOptions(offset.left, yPos);
                }
            });
            this._parametersContainer = _functionParametersContainerCS.instantiate();
            this._parametersContainer.on("scroll", function () {
                Core.hidePopup();
                _this._host.hideCachedForms();
            });
            this._viewModel = new ViewModel(this);
            ko.applyBindings(this._viewModel, this._parametersContainer[0]);
        }
        Object.defineProperty(QueryNavigatorInvocationViewHost.prototype, "layoutContainer", {
            get: function () {
                return this._masterLayoutContainer;
            },
            enumerable: true,
            configurable: true
        });
        QueryNavigatorInvocationViewHost.prototype.apply = function () {
            var parameters = this.getParameters();
            if (parameters.length) {
                return this._host.applyParameters(JSON.stringify(parameters));
            }
            return true;
        };
        QueryNavigatorInvocationViewHost.prototype.chooseValue = function (name, isMultipleSelection, userValue) {
            this._host.chooseValue(name, isMultipleSelection, userValue, JSON.stringify(this.getParameters()));
        };
        QueryNavigatorInvocationViewHost.prototype.updateUserValue = function (name, isMultipleSelection, newValue) {
            this._host.updateUserValue(name, isMultipleSelection, newValue);
        };
        QueryNavigatorInvocationViewHost.prototype.toggleDisplayFilter = function (hideOptionalParameters) {
            _inlineInvocationViewCS.instantiate().toggleClass(_hideOptionalParametersContextClass, hideOptionalParameters);
            this.resizeLayout();
        };
        QueryNavigatorInvocationViewHost.prototype.updateFunctionParameterViewModels = function (jsonViewModel) {
            var jsonHostViewModel = JSON.parse(jsonViewModel);
            this._viewModel.update(jsonHostViewModel);
            this.resizeLayout();
        };
        QueryNavigatorInvocationViewHost.prototype.updateValuePickerValue = function (name, shorthand, displayValue) {
            var groupViewModels = this._viewModel.parameterGroupViewModels();
            for (var j = 0; j < groupViewModels.length; j++) {
                var templateViewModels = groupViewModels[j].templateViewModels();
                for (var k = 0; k < templateViewModels.length; k++) {
                    if (name === templateViewModels[k].templateData.name) {
                        if (templateViewModels[k].templateData instanceof ValuePickerParameterViewModel) {
                            templateViewModels[k].templateData.update(shorthand, displayValue);
                            return;
                        }
                        else {
                            throw new Error(name + " parameter is not of type ValuePickerParameterViewModel");
                        }
                    }
                }
            }
        };
        QueryNavigatorInvocationViewHost.prototype.showValidationErrors = function (jsonViewModels) {
            var jsonParameterViewModels = JSON.parse(jsonViewModels);
            if (jsonParameterViewModels.length) {
                this.onShowValidationErrors();
            }
            else {
                this.onHideValidationErrors();
            }
            var groupViewModels = this._viewModel.parameterGroupViewModels();
            for (var i = 0; i < jsonParameterViewModels.length; i++) {
                for (var j = 0; j < groupViewModels.length; j++) {
                    var templateViewModels = groupViewModels[j].templateViewModels();
                    for (var k = 0; k < templateViewModels.length; k++) {
                        if (jsonParameterViewModels[i].name === templateViewModels[k].templateData.name) {
                            templateViewModels[k].templateData.validationErrorMessage(jsonParameterViewModels[i].validationErrorMessage);
                        }
                    }
                }
            }
        };
        QueryNavigatorInvocationViewHost.prototype.show = function () {
            this._masterLayoutContainer.setVisible(true, true);
        };
        QueryNavigatorInvocationViewHost.prototype.hide = function () {
            this._masterLayoutContainer.setVisible(false, true);
        };
        QueryNavigatorInvocationViewHost.prototype.setDescriptionText = function (text) {
            _descriptionContainerCS.instantiate().text(text);
        };
        QueryNavigatorInvocationViewHost.prototype.validateField = function (name) {
            return this._host.validateField(name, JSON.stringify(this.getParameters()));
        };
        QueryNavigatorInvocationViewHost.prototype.onHideValidationErrors = function () {
            var applyButtonElement = _invokeButtonCS.instantiate();
            if (applyButtonElement.length) {
                Button.from(applyButtonElement).disabled(false);
            }
            if (this._hideValidationErrorCallback) {
                this._hideValidationErrorCallback();
            }
        };
        QueryNavigatorInvocationViewHost.prototype.onShowValidationErrors = function () {
            var applyButtonElement = _invokeButtonCS.instantiate();
            if (applyButtonElement.length) {
                Button.from(applyButtonElement).disabled(true);
            }
            if (this._showValidationErrorCallback) {
                this._showValidationErrorCallback();
            }
            window.requestAnimationFrame(function () {
                var errorBox = _functionParametersContainerCS.descendants("js-errorBox:visible").instantiate();
                if (errorBox.length) {
                    errorBox.eq(0).parent()[0].scrollIntoView(false);
                }
            });
        };
        QueryNavigatorInvocationViewHost.prototype.unbindEventHandlers = function () {
            this._parametersContainer.off("scroll");
        };
        QueryNavigatorInvocationViewHost.prototype.getParameters = function () {
            var groupViewModels = this._viewModel.parameterGroupViewModels();
            var parameters = [];
            for (var i = 0; i < groupViewModels.length; i++) {
                var templateViewModels = groupViewModels[i].templateViewModels();
                for (var j = 0; j < templateViewModels.length; j++) {
                    parameters.push({
                        functionId: templateViewModels[j].templateData.functionId,
                        paramName: templateViewModels[j].templateData.paramName,
                        name: templateViewModels[j].templateData.name,
                        value: templateViewModels[j].templateData.shorthandValue()
                    });
                }
            }
            return parameters;
        };
        QueryNavigatorInvocationViewHost.prototype.resizeLayout = function () {
            var height = _descriptionContainerCS.instantiate().outerHeight(true) +
                _displayFilterContainerCS.instantiate().outerHeight(true) +
                _buttonsContainerCS.instantiate().outerHeight(true);
            var parametersHeight = 0;
            var parametersGroup = _functionParametersContainerCS.instantiate();
            var visibleFields = parametersGroup.children(":visible");
            if (visibleFields.length) {
                var lastChild = visibleFields.last();
                parametersHeight += lastChild.position().top;
                parametersHeight += lastChild.outerHeight(true) + 1;
            }
            var maxHeight = parseInt(parametersGroup.css("max-height"));
            if (!isNaN(maxHeight)) {
                height += Math.min(maxHeight, parametersHeight);
            }
            else {
                height += parametersHeight;
            }
            this._masterLayoutContainer.resize({ height: height });
        };
        return QueryNavigatorInvocationViewHost;
    })();
    Controls.QueryNavigatorInvocationViewHost = QueryNavigatorInvocationViewHost;
    var TemplateName = (function () {
        function TemplateName() {
        }
        TemplateName.inputFieldParameterTemplate = "navigatorInvocationInputFieldParameterTemplate";
        TemplateName.dropdownFieldParameterTemplate = "navigatorInvocationDropdownFieldParameterTemplate";
        TemplateName.checkboxGroupFieldParameterTemplate = "navigatorInvocationCheckboxGroupFieldParameterTemplate";
        TemplateName.valuePickerFieldParameterTemplate = "navigatorInvocationValuePickerFieldParameterTemplate";
        TemplateName.valuePickerFieldParameterTemplateWithInput = "navigatorInvocationValuePickerFieldParameterTemplateWithInput";
        return TemplateName;
    })();
    var ViewModel = (function () {
        function ViewModel(invocationViewHost) {
            var _this = this;
            this.parameterGroupViewModels = ko.observableArray([]);
            this.showAsGroup = ko.computed(function () {
                return !(_this.parameterGroupViewModels().length === 1 && _this.parameterGroupViewModels()[0].groupName() === null);
            });
            this._invocationViewHost = invocationViewHost;
        }
        ViewModel.prototype.update = function (jsonHostViewModel) {
            var viewModels = [];
            for (var i = 0; i < jsonHostViewModel.jsonParameterGroupViewModels.length; i++) {
                var groupViewModel = [];
                var jsonGroupViewModel = jsonHostViewModel.jsonParameterGroupViewModels[i];
                for (var j = 0; j < jsonGroupViewModel.templateViewModels.length; j++) {
                    if (jsonGroupViewModel.templateViewModels[j].templateName === TemplateName.inputFieldParameterTemplate) {
                        groupViewModel.push(new ParameterTemplateViewModel(jsonGroupViewModel.templateViewModels[j].templateName, new InputParameterViewModel(jsonGroupViewModel.templateViewModels[j].templateData, this._invocationViewHost)));
                    }
                    else if (jsonGroupViewModel.templateViewModels[j].templateName === TemplateName.dropdownFieldParameterTemplate) {
                        groupViewModel.push(new ParameterTemplateViewModel(jsonGroupViewModel.templateViewModels[j].templateName, new DropdownFieldParameterViewModel(jsonGroupViewModel.templateViewModels[j].templateData, this._invocationViewHost)));
                    }
                    else if (jsonGroupViewModel.templateViewModels[j].templateName === TemplateName.checkboxGroupFieldParameterTemplate) {
                        groupViewModel.push(new ParameterTemplateViewModel(jsonGroupViewModel.templateViewModels[j].templateName, new CheckboxGroupParameterViewModel(jsonGroupViewModel.templateViewModels[j].templateData, this._invocationViewHost)));
                    }
                    else if (jsonGroupViewModel.templateViewModels[j].templateName === TemplateName.valuePickerFieldParameterTemplate) {
                        groupViewModel.push(new ParameterTemplateViewModel(jsonGroupViewModel.templateViewModels[j].templateName, new ValuePickerParameterViewModel(jsonGroupViewModel.templateViewModels[j].templateData, this._invocationViewHost, false)));
                    }
                    else if (jsonGroupViewModel.templateViewModels[j].templateName === TemplateName.valuePickerFieldParameterTemplateWithInput) {
                        groupViewModel.push(new ParameterTemplateViewModel(jsonGroupViewModel.templateViewModels[j].templateName, new ValuePickerParameterViewModel(jsonGroupViewModel.templateViewModels[j].templateData, this._invocationViewHost, true)));
                    }
                }
                viewModels.push(new ParameterGroupViewModel(jsonGroupViewModel.groupName, jsonGroupViewModel.isOptional, groupViewModel));
            }
            this.parameterGroupViewModels(viewModels);
        };
        return ViewModel;
    })();
    var ParameterGroupViewModel = (function () {
        function ParameterGroupViewModel(groupName, isOptional, templateViewModels) {
            this.groupName = ko.observable("");
            this.isOptional = ko.observable(isOptional);
            this.templateViewModels = ko.observableArray([]);
            this.update(groupName, templateViewModels);
        }
        ParameterGroupViewModel.prototype.update = function (groupName, templateViewModels) {
            this.groupName(groupName);
            this.templateViewModels(templateViewModels);
        };
        return ParameterGroupViewModel;
    })();
    var ParameterTemplateViewModel = (function () {
        function ParameterTemplateViewModel(templateName, viewModel) {
            this.templateName = templateName;
            this.templateData = viewModel;
        }
        return ParameterTemplateViewModel;
    })();
    var ParameterViewModel = (function () {
        function ParameterViewModel(jsonViewModel) {
            this.name = jsonViewModel.name;
            this.validationErrorMessage = ko.observable(jsonViewModel.validationErrorMessage);
            this.optional = jsonViewModel.optional;
        }
        ParameterViewModel.prototype.shorthandValue = function () {
            var value = this._getValue();
            if (!Core.isNullOrUndefined(value) && value.length) {
                return value;
            }
            else if (this.optional) {
                return "null";
            }
            else {
                return null;
            }
        };
        ParameterViewModel.prototype._getValue = function () {
            throw "not implemented";
        };
        return ParameterViewModel;
    })();
    var InputParameterViewModel = (function (_super) {
        __extends(InputParameterViewModel, _super);
        function InputParameterViewModel(jsonViewModel, invocationViewHost) {
            var _this = this;
            _super.call(this, jsonViewModel);
            this._invocationViewHost = invocationViewHost;
            this.inputFieldViewModel = new Widgets.InputFieldViewModel(jsonViewModel.jsonInputFieldViewModel, function () {
                _this.validationErrorMessage("");
                _this._invocationViewHost.onHideValidationErrors();
            });
            this.inputFieldViewModel.value.subscribe(function () {
                var errorMessage = _this._invocationViewHost.validateField(_this.name);
                _this.validationErrorMessage(errorMessage);
                if (errorMessage.length) {
                    _this._invocationViewHost.onShowValidationErrors();
                }
            });
        }
        InputParameterViewModel.prototype._getValue = function () {
            return this.inputFieldViewModel.value();
        };
        return InputParameterViewModel;
    })(ParameterViewModel);
    var DropdownFieldParameterViewModel = (function (_super) {
        __extends(DropdownFieldParameterViewModel, _super);
        function DropdownFieldParameterViewModel(jsonViewModel, invocationViewHost) {
            var _this = this;
            _super.call(this, jsonViewModel);
            this._invocationViewHost = invocationViewHost;
            this.label = jsonViewModel.label;
            this.name = jsonViewModel.name;
            this.dropDownViewModel = new Widgets.DropdownViewModel(jsonViewModel.jsonDropDownViewModel);
            this.dropDownViewModel.selectedValue.subscribe(function () {
                var errorMessage = _this._invocationViewHost.validateField(_this.name);
                _this.validationErrorMessage(errorMessage);
                if (errorMessage.length) {
                    _this._invocationViewHost.onShowValidationErrors();
                }
                else {
                    _this._invocationViewHost.onHideValidationErrors();
                }
            });
            this.dropDownViewModel.inputFieldValue.subscribe(function () {
                var errorMessage = _this._invocationViewHost.validateField(_this.name);
                _this.validationErrorMessage(errorMessage);
                if (errorMessage.length) {
                    _this._invocationViewHost.onShowValidationErrors();
                }
                else {
                    _this._invocationViewHost.onHideValidationErrors();
                }
            });
        }
        DropdownFieldParameterViewModel.prototype._getValue = function () {
            return this.dropDownViewModel.inputFieldValue();
        };
        return DropdownFieldParameterViewModel;
    })(ParameterViewModel);
    var CheckboxGroupParameterViewModel = (function (_super) {
        __extends(CheckboxGroupParameterViewModel, _super);
        function CheckboxGroupParameterViewModel(jsonViewModel, invocationViewHost) {
            var _this = this;
            _super.call(this, jsonViewModel);
            this._invocationViewHost = invocationViewHost;
            this.name = jsonViewModel.name;
            this.checkboxGroupViewModel = new Widgets.CheckBoxGroupViewModel(jsonViewModel.jsonCheckboxGroupViewModel);
            this.checkboxGroupViewModel.value.subscribe(function () {
                var errorMessage = _this._invocationViewHost.validateField(_this.name);
                _this.validationErrorMessage(errorMessage);
                if (errorMessage.length) {
                    _this._invocationViewHost.onShowValidationErrors();
                }
                else {
                    _this._invocationViewHost.onHideValidationErrors();
                }
            });
        }
        CheckboxGroupParameterViewModel.prototype._getValue = function () {
            return this.checkboxGroupViewModel.value();
        };
        return CheckboxGroupParameterViewModel;
    })(ParameterViewModel);
    var ValuePickerParameterViewModel = (function (_super) {
        __extends(ValuePickerParameterViewModel, _super);
        function ValuePickerParameterViewModel(jsonViewModel, invocationViewHost, allowedValuesIsOpenSet) {
            var _this = this;
            _super.call(this, jsonViewModel);
            this._invocationViewHost = invocationViewHost;
            this.name = jsonViewModel.name;
            this.label = jsonViewModel.label;
            this.functionId = jsonViewModel.functionId;
            this.paramName = jsonViewModel.paramName;
            this.value = ko.observable(jsonViewModel.value);
            this.displayString = ko.observable(jsonViewModel.displayString);
            this.isMultipleSelection = jsonViewModel.isMultipleSelection;
            this.value.subscribe(function () {
                var errorMessage = _this._invocationViewHost.validateField(_this.name);
                _this.validationErrorMessage(errorMessage);
                if (errorMessage.length) {
                    _this._invocationViewHost.onShowValidationErrors();
                }
                else {
                    _this._invocationViewHost.onHideValidationErrors();
                }
            });
            this.allowedValuesIsOpenSet = allowedValuesIsOpenSet;
            if (this.allowedValuesIsOpenSet) {
                this.userValue = ko.computed({
                    read: this.displayString,
                    write: function (newValue) {
                        this._invocationViewHost.updateUserValue(this.name, this.isMultipleSelection, newValue);
                    },
                    owner: this
                });
            }
        }
        ValuePickerParameterViewModel.prototype.onValuePickerButtonClick = function () {
            this.chooseValue();
        };
        ValuePickerParameterViewModel.prototype.onValuePickerFieldClick = function () {
            this.chooseValue();
        };
        ValuePickerParameterViewModel.prototype.update = function (shorthand, displayString) {
            this.value(shorthand);
            this.displayString(displayString);
        };
        ValuePickerParameterViewModel.prototype._getValue = function () {
            return this.value();
        };
        ValuePickerParameterViewModel.prototype.chooseValue = function () {
            this._invocationViewHost.chooseValue(this.name, this.isMultipleSelection, this.allowedValuesIsOpenSet ? this.displayString() : null);
        };
        return ValuePickerParameterViewModel;
    })(ParameterViewModel);
})(Controls || (Controls = {}));
Q	  // Copyright (C) Microsoft Corporation. All rights reserved.
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var NavigatorFloatingDialog;
(function (NavigatorFloatingDialog) {
    var NavigatorViewHost = (function (_super) {
        __extends(NavigatorViewHost, _super);
        function NavigatorViewHost(container, parent, host) {
            _super.call(this, container, parent, host);
        }
        NavigatorViewHost.prototype.onLeafDoubleClicked = function (node, label, nodePath) {
            var params = {
                path: this.control().treePath(node)
            };
            this._getParent().onLeafDoubleClicked(JSON.stringify(params));
        };
        NavigatorViewHost.prototype.showNodeContextMenu = function (node, left, top) {
            var nodeOffset = node.offset();
            var elementTop = nodeOffset.top;
            var elementHeight = node.height();
            var args = {
                path: this.control().treePath(node)
            };
            this._getParent().showNodeContextMenu(JSON.stringify(args), left, top, elementTop, elementHeight);
        };
        NavigatorViewHost.prototype._createLayoutContainer = function () {
            return null;
        };
        NavigatorViewHost.prototype.multiSelectionMode = function (value) {
            if (this.control() && !Core.isNullOrUndefined(value)) {
                this.control().multiSelectionCoupleActivation(false);
            }
            return _super.prototype.multiSelectionMode.call(this, value);
        };
        NavigatorViewHost.prototype.validateSelection = function (node) {
            var args = {
                path: this.control().treePath(node)
            };
            return this._getParent().validateSelection(JSON.stringify(args));
        };
        NavigatorViewHost.prototype._getParent = function () {
            return _super.prototype._getParent.call(this);
        };
        return NavigatorViewHost;
    })(Controls.BaseNavigatorViewHost);
    NavigatorFloatingDialog.NavigatorViewHost = NavigatorViewHost;
})(NavigatorFloatingDialog || (NavigatorFloatingDialog = {}));
�  //----------------------------------------------------------
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
        try {
            Host.instance.assertFail(message);
        }
        catch (ex) { }
    }
    Debug.fail = fail;
    function log(message) {
        try {
            Host.instance.log(message);
        }
        catch (ex) { }
    }
    Debug.log = log;
})(Debug || (Debug = {}));
var Verify;
(function (Verify) {
    function hasValue(value, name) {
        if (value === null || value === undefined) {
            throw new Error("Unexpected null or undefined in: " + name);
        }
    }
    Verify.hasValue = hasValue;
    function isInRangeInclusive(value, rangeStart, rangeLength, valueName) {
        var rangeEnd = rangeStart + rangeLength - 1;
        if (value < rangeStart || value > rangeEnd) {
            var messageTemplate = "{0} is out of range. Value: {1}, Range: [{2}, {3}].";
            throw new Error(messageTemplate.format(valueName, value, rangeStart, rangeEnd));
        }
    }
    Verify.isInRangeInclusive = isInRangeInclusive;
    function isTrue(value, message) {
        if (!value) {
            throw new Error(message);
        }
    }
    Verify.isTrue = isTrue;
})(Verify || (Verify = {}));
�  //----------------------------------------------------------
// Copyright (C) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------
var LoadingPane = (function (window, undefined) {
    var widgetName = "loadingpane";
    var _dataName = "msde-" + widgetName;
    var _loadingPaneCS = new ClassSelectorBuilder("o-group-loadingPane");
    var _loadingPaneMessageCS = new ClassSelectorBuilder("o-content-message");
    var _loadingPaneImageCS = new ClassSelectorBuilder("o-content-image");
    $.widget("msde." + widgetName, (function () {
        var options = {
            click: $.noop,
            contextmenu: $.noop,
            mouseenter: $.noop,
            show: $
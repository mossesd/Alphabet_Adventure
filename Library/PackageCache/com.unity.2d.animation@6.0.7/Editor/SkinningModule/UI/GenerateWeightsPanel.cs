se/env', 'vs/base/lifecycle', 'vs/editor/editorExtensions', "vs/css!./workerStatusReporter"], function (require, exports, editor, env, lifecycle, editorExtensions) {
    var WorkerStatusReporter = (function () {
        function WorkerStatusReporter(ctx, editor) {
            this._threadService = ctx.threadService;
            this._threadService.addStatusListener(this);
            this._editor = editor;
            this._toDispose = [];
            this._domNodes = [];
            this._domNode = document.createElement('div');
            this._domNode.className = 'monaco-worker-status';
            if (env.browser.canUseTranslate3d) {
                // Put the worker reporter in its own layer
                this._domNode.style.transform = 'translate3d(0px, 0px, 0px)';
            }
            this._editor.addOverlayWidget(this);
        }
        WorkerStatusReporter.prototype.getId = function () {
            return WorkerStatusReporter.ID;
        };
        WorkerStatusReporter.prototype.dispose = function () {
            this._threadService.removeStatusListener(this);
            this._toDispose = lifecycle.disposeAll(this._toDispose);
        };
        WorkerStatusReporter.prototype.getDomNode = function () {
            return this._domNode;
        };
        WorkerStatusReporter.prototype.getPosition = function () {
            return { preference: editor.OverlayWidgetPositionPreference.TOP_RIGHT_CORNER };
        };
        WorkerStatusReporter.prototype._ensureDomNodes = function (desiredCount) {
            for (var i = this._domNodes.length - 1; i >= desiredCount; i++) {
                this._domNode.removeChild(this._domNodes[i]);
                this._domNodes.splice(i, 1);
            }
            for (var i = this._domNodes.length; i < desiredCount; i++) {
                this._domNodes[i] = document.createElement('div');
                this._domNodes[i].className = 'worker';
                this._domNode.appendChild(this._domNodes[i]);
            }
        };
        WorkerStatusReporter.prototype.onThreadServiceStatus = function (status) {
            this._ensureDomNodes(status.workers.length);
            for (var i = 0; i < status.workers.length; i++) {
                var cnt = status.workers[i].queueSize;
                var workerStatus = 'idle';
                if (cnt > 5) {
                    workerStatus = 'flooded';
                }
                else if (cnt > 0) {
                    workerStatus = 'busy';
                }
                attr(this._domNodes[i], 'status', workerStatus);
            }
        };
        WorkerStatusReporter.ID = 'editor.contrib.workerStatusReporter';
        return WorkerStatusReporter;
    })();
    function attr(target, attrName, attrValue) {
        target.setAttribute(attrName, attrValue);
    }
    if (env.enableEditorLanguageServiceIndicator) {
        editorExtensions.registerEditorContribution(WorkerStatusReporter);
    }
});


'use strict';
var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
define('vs/editor/contrib/multicursor/multicursor',["require", "exports", 'vs/nls!vs/
         return false;
            }
            this._stopSelectionMode();
            return true;
        };
        // -------------------- STOP handlers that simply change cursor state
        // -------------------- START type interceptors & co.
        OneCursor.prototype._typeInterceptorEnter = function (ch, ctx) {
            if (ch !== '\n') {
                return false;
            }
            return this._enter(false, ctx);
        };
        OneCursor.prototype.lineInsertBefore = function (ctx) {
            var lineNumber = this.position.lineNumber;
            var column = 0;
            if (lineNumber > 1) {
                lineNumber--;
                column = this.model.getLineMaxColumn(lineNumber);
            }
            return this._enter(false, ctx, new Position.Position(lineNumber, column), new Range.Range(lineNumber, column, lineNumber, column));
        };
        OneCursor.prototype.lineInsertAfter = function (ctx) {
            var column = this.model.getLineMaxColumn(this.position.lineNumber);
            return this._enter(false, ctx, new Position.Position(this.position.lineNumber, column), new Range.Range(this.position.lineNumber, column, this.position.lineNumber, col
tly that's... still OK?


    return m;
  };
  /**
   * Create a clone of the matrix
   * @memberof SparseMatrix
   * @return {SparseMatrix} clone
   */


  SparseMatrix.prototype.clone = function () {
    var m = new SparseMatrix({
      values: this._values ? object.clone(this._values) : undefined,
      index: object.clone(this._index),
      ptr: object.clone(this._ptr),
      size: object.clone(this._size),
      datatype: this._datatype
    });
    return m;
  };
  /**
   * Retrieve the size of the matrix.
   * @memberof SparseMatrix
   * @returns {number[]} size
   */


  SparseMatrix.prototype.size = function () {
    return this._size.slice(0); // copy the Array
  };
  /**
   * Create a new matrix with the results of the callback function executed on
   * each entry of the matrix.
   * @memberof SparseMatrix
   * @param {Function} callback   The callback function is invoked with three
   *                              parameters: the value of the element, the index
   *                              of the element, and the Matrix being traversed.
   * @param {boolean} [skipZeros] Invoke callback function for non-zero values only.
   *
   * @return {SparseMatrix} matrix
   */


  SparseMatrix.prototype.map = function (callback, skipZeros) {
    // check it is a pattern matrix
    if (!this._values) {
      throw new Error('Cannot invoke map on a Pattern only matrix');
    } // matrix instance


    var me = this; // rows and columns

    var rows = this._size[0];
    var columns = this._size[1]; // invoke callback

    var invoke = function invoke(v, i, j) {
      // invoke callback
      return callback(v, [i, j], me);
    }; // invoke _map


    return _map(this, 0, rows - 1, 0, columns - 1, invoke, skipZeros);
  };
  /**
   * Create a new matrix with the results of the callback function executed on the interval
   * [minRow..maxRow, minColumn
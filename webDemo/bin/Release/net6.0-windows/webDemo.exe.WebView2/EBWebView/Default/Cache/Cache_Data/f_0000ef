define(['dart_sdk', 'packages/lottie/src/parser/moshi/buffer.dart', 'packages/lottie/src/parser/moshi/json_scope.dart'], (function load__packages__lottie__src__parser__moshi__json_utf8_reader_dart(dart_sdk, packages__lottie__src__parser__moshi__buffer$46dart, packages__lottie__src__parser__moshi__json_scope$46dart) {
  'use strict';
  const core = dart_sdk.core;
  const _internal = dart_sdk._internal;
  const typed_data = dart_sdk.typed_data;
  const convert = dart_sdk.convert;
  const dart = dart_sdk.dart;
  const dartx = dart_sdk.dartx;
  const buffer = packages__lottie__src__parser__moshi__buffer$46dart.src__parser__moshi__buffer;
  const json_scope = packages__lottie__src__parser__moshi__json_scope$46dart.src__parser__moshi__json_scope;
  var json_utf8_reader = Object.create(dart.library);
  var json_reader = Object.create(dart.library);
  var $_set = dartx._set;
  var $_get = dartx._get;
  var $codeUnitAt = dartx.codeUnitAt;
  var $length = dartx.length;
  var $toString = dartx.toString;
  var $toDouble = dartx.toDouble;
  var $isNaN = dartx.isNaN;
  var $isInfinite = dartx.isInfinite;
  var $toInt = dartx.toInt;
  var $map = dartx.map;
  var $toList = dartx.toList;
  dart._checkModuleNullSafetyMode(true);
  dart._checkModuleRuntimeTypes(false);
  var T = {
    VoidToString: () => (T.VoidToString = dart.constFn(dart.fnType(core.String, [])))(),
    StringTodynamic: () => (T.StringTodynamic = dart.constFn(dart.fnType(dart.dynamic, [core.String])))(),
    ListOfint: () => (T.ListOfint = dart.constFn(core.List$(core.int)))(),
    StringN: () => (T.StringN = dart.constFn(dart.nullable(core.String)))(),
    ListOfStringN: () => (T.ListOfStringN = dart.constFn(core.List$(T.StringN())))(),
    StringToListOfint: () => (T.StringToListOfint = dart.constFn(dart.fnType(T.ListOfint(), [core.String])))()
  };
  const CT = Object.create({
    _: () => (C, CT)
  });
  dart.defineLazy(CT, {
    get C1() {
      return C[1] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "beginArray",
        [_Enum_index]: 0
      });
    },
    get C2() {
      return C[2] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "endArray",
        [_Enum_index]: 1
      });
    },
    get C3() {
      return C[3] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "beginObject",
        [_Enum_index]: 2
      });
    },
    get C4() {
      return C[4] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "endObject",
        [_Enum_index]: 3
      });
    },
    get C5() {
      return C[5] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "name",
        [_Enum_index]: 4
      });
    },
    get C6() {
      return C[6] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "string",
        [_Enum_index]: 5
      });
    },
    get C7() {
      return C[7] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "number",
        [_Enum_index]: 6
      });
    },
    get C8() {
      return C[8] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "boolean",
        [_Enum_index]: 7
      });
    },
    get C9() {
      return C[9] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "nullToken",
        [_Enum_index]: 8
      });
    },
    get C10() {
      return C[10] = dart.const({
        __proto__: json_reader.Token.prototype,
        [_Enum__name]: "endDocument",
        [_Enum_index]: 9
      });
    },
    get C0() {
      return C[0] = dart.constList([C[1] || CT.C1, C[2] || CT.C2, C[3] || CT.C3, C[4] || CT.C4, C[5] || CT.C5, C[6] || CT.C6, C[7] || CT.C7, C[8] || CT.C8, C[9] || CT.C9, C[10] || CT.C10], json_reader.Token);
    }
  }, false);
  var C = Array(11).fill(void 0);
  var I = [
    "package:lottie/src/parser/moshi/json_reader.dart",
    "package:lottie/src/parser/moshi/json_utf8_reader.dart"
  ];
  var buffer$ = dart.privateName(json_utf8_reader, "JsonUtf8Reader.buffer");
  var _peeked = dart.privateName(json_utf8_reader, "_peeked");
  var __JsonUtf8Reader__peekedLong = dart.privateName(json_utf8_reader, "_#JsonUtf8Reader#_peekedLong");
  var __JsonUtf8Reader__peekedNumberLength = dart.privateName(json_utf8_reader, "_#JsonUtf8Reader#_peekedNumberLength");
  var _peekedString = dart.privateName(json_utf8_reader, "_peekedString");
  var _peekedLong = dart.privateName(json_utf8_reader, "_peekedLong");
  var _peekedNumberLength = dart.privateName(json_utf8_reader, "_peekedNumberLength");
  var _doPeek = dart.privateName(json_utf8_reader, "_doPeek");
  var _nextNonWhitespace = dart.privateName(json_utf8_reader, "_nextNonWhitespace");
  var _checkLenient = dart.privateName(json_utf8_reader, "_checkLenient");
  var _nextQuotedValue = dart.privateName(json_utf8_reader, "_nextQuotedValue");
  var _findName = dart.privateName(json_utf8_reader, "_findName");
  var _skipToEndOfBlockComment = dart.privateName(json_utf8_reader, "_skipToEndOfBlockComment");
  var _skipToEndOfLine = dart.privateName(json_utf8_reader, "_skipToEndOfLine");
  var stackSize = dart.privateName(json_reader, "JsonReader.stackSize");
  var scopes = dart.privateName(json_reader, "JsonReader.scopes");
  var pathNames = dart.privateName(json_reader, "JsonReader.pathNames");
  var pathIndices = dart.privateName(json_reader, "JsonReader.pathIndices");
  var lenient = dart.privateName(json_reader, "JsonReader.lenient");
  var failOnUnknown = dart.privateName(json_reader, "JsonReader.failOnUnknown");
  json_reader.JsonReader = class JsonReader extends core.Object {
    get stackSize() {
      return this[stackSize];
    }
    set stackSize(value) {
      this[stackSize] = value;
    }
    get scopes() {
      return this[scopes];
    }
    set scopes(value) {
      this[scopes] = value;
    }
    get pathNames() {
      return this[pathNames];
    }
    set pathNames(value) {
      this[pathNames] = value;
    }
    get pathIndices() {
      return this[pathIndices];
    }
    set pathIndices(value) {
      this[pathIndices] = value;
    }
    get lenient() {
      return this[lenient];
    }
    set lenient(value) {
      this[lenient] = value;
    }
    get failOnUnknown() {
      return this[failOnUnknown];
    }
    set failOnUnknown(value) {
      this[failOnUnknown] = value;
    }
    static fromBytes(source) {
      return new json_utf8_reader.JsonUtf8Reader.new(new buffer.Buffer.new(source));
    }
    static _copyOf(T, source, newSize, fill) {
      let newList = core.List$(T).filled(newSize, fill);
      core.List.copyRange(T, newList, 0, source);
      return newList;
    }
    pushScope(newTop) {
      let t6;
      if (this.stackSize === this.scopes[$length]) {
        if (this.stackSize === 256) {
          dart.throw(new json_reader.JsonDataException.new("Nesting too deep at " + this.getPath()));
        }
        this.scopes = json_reader.JsonReader._copyOf(core.int, this.scopes, this.scopes[$length] * 2, 0);
        this.pathNames = json_reader.JsonReader._copyOf(T.StringN(), this.pathNames, this.pathNames[$length] * 2, null);
        this.pathIndices = json_reader.JsonReader._copyOf(core.int, this.pathIndices, this.pathIndices[$length] * 2, 0);
      }
      this.scopes[$_set]((t6 = this.stackSize, this.stackSize = t6 + 1, t6), newTop);
    }
    syntaxError(message) {
      dart.throw(new json_reader.JsonEncodingException.new(message + " at path " + this.getPath()));
    }
    getPath() {
      return json_scope.JsonScope.getPath(this.stackSize, this.scopes, this.pathNames, this.pathIndices);
    }
  };
  (json_reader.JsonReader.new = function() {
    this[stackSize] = 0;
    this[scopes] = T.ListOfint().filled(32, 0);
    this[pathNames] = T.ListOfStringN().filled(32, null);
    this[pathIndices] = T.ListOfint().filled(32, 0);
    this[lenient] = false;
    this[failOnUnknown] = false;
    ;
  }).prototype = json_reader.JsonReader.prototype;
  dart.addTypeTests(json_reader.JsonReader);
  dart.addTypeCaches(json_reader.JsonReader);
  dart.setMethodSignature(json_reader.JsonReader, () => ({
    __proto__: dart.getMethods(json_reader.JsonReader.__proto__),
    pushScope: dart.fnType(dart.void, [core.int]),
    syntaxError: dart.fnType(json_reader.JsonEncodingException, [core.String]),
    getPath: dart.fnType(core.String, [])
  }));
  dart.setStaticMethodSignature(json_reader.JsonReader, () => ['fromBytes', '_copyOf']);
  dart.setLibraryUri(json_reader.JsonReader, I[0]);
  dart.setFieldSignature(json_reader.JsonReader, () => ({
    __proto__: dart.getFields(json_reader.JsonReader.__proto__),
    stackSize: dart.fieldType(core.int),
    scopes: dart.fieldType(core.List$(core.int)),
    pathNames: dart.fieldType(core.List$(dart.nullable(core.String))),
    pathIndices: dart.fieldType(core.List$(core.int)),
    lenient: dart.fieldType(core.bool),
    failOnUnknown: dart.fieldType(core.bool)
  }));
  json_utf8_reader.JsonUtf8Reader = class JsonUtf8Reader extends json_reader.JsonReader {
    get buffer() {
      return this[buffer$];
    }
    set buffer(value) {
      super.buffer = value;
    }
    set [_peekedLong](library$32package$58lottie$47src$47parser$47moshi$47json_utf8_reader$46dart$58$58_peekedLong$35param) {
      this[__JsonUtf8Reader__peekedLong] = library$32package$58lottie$47src$47parser$47moshi$47json_utf8_reader$46dart$58$58_peekedLong$35param;
    }
    get [_peekedLong]() {
      let t0;
      t0 = this[__JsonUtf8Reader__peekedLong];
      return t0 == null ? dart.throw(new _internal.LateError.fieldNI("_peekedLong")) : t0;
    }
    get [_peekedNumberLength]() {
      let t0;
      t0 = this[__JsonUtf8Reader__peekedNumberLength];
      return t0 == null ? dart.throw(new _internal.LateError.fieldNI("_peekedNumberLength")) : t0;
    }
    set [_peekedNumberLength](library$32package$58lottie$47src$47parser$47moshi$47json_utf8_reader$46dart$58$58_peekedNumberLength$35param) {
      this[__JsonUtf8Reader__peekedNumberLength] = library$32package$58lottie$47src$47parser$47moshi$47json_utf8_reader$46dart$58$58_peekedNumberLength$35param;
    }
    static ['_#new#tearOff'](buffer) {
      return new json_utf8_reader.JsonUtf8Reader.new(buffer);
    }
    beginArray() {
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 3) {
        this.pushScope(1);
        this.pathIndices[$_set](this.stackSize - 1, 0);
        this[_peeked] = 0;
      } else {
        dart.throw(new json_reader.JsonDataException.new("Expected BEGIN_ARRAY but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
    }
    endArray() {
      let t1, t0;
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 4) {
        this.stackSize = this.stackSize - 1;
        t0 = this.pathIndices;
        t1 = this.stackSize - 1;
        t0[$_set](t1, t0[$_get](t1) + 1);
        this[_peeked] = 0;
      } else {
        dart.throw(new json_reader.JsonDataException.new("Expected END_ARRAY but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
    }
    beginObject() {
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 1) {
        this.pushScope(3);
        this[_peeked] = 0;
      } else {
        dart.throw(new json_reader.JsonDataException.new("Expected BEGIN_OBJECT but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
    }
    endObject() {
      let t1, t0;
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 2) {
        this.stackSize = this.stackSize - 1;
        this.pathNames[$_set](this.stackSize, null);
        t0 = this.pathIndices;
        t1 = this.stackSize - 1;
        t0[$_set](t1, t0[$_get](t1) + 1);
        this[_peeked] = 0;
      } else {
        dart.throw(new json_reader.JsonDataException.new("Expected END_OBJECT but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
    }
    hasNext() {
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      return p !== 2 && p !== 4 && p !== 18;
    }
    peek() {
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      switch (p) {
        case 1:
          {
            return json_reader.Token.beginObject;
          }
        case 2:
          {
            return json_reader.Token.endObject;
          }
        case 3:
          {
            return json_reader.Token.beginArray;
          }
        case 4:
          {
            return json_reader.Token.endArray;
          }
        case 12:
        case 13:
        case 14:
        case 15:
          {
            return json_reader.Token.name_;
          }
        case 5:
        case 6:
          {
            return json_reader.Token.boolean;
          }
        case 7:
          {
            return json_reader.Token.nullToken;
          }
        case 8:
        case 9:
        case 10:
        case 11:
          {
            return json_reader.Token.string;
          }
        case 16:
        case 17:
          {
            return json_reader.Token.number;
          }
        case 18:
          {
            return json_reader.Token.endDocument;
          }
        default:
          {
            dart.throw(new core.AssertionError.new());
          }
      }
    }
    [_doPeek]() {
      let peekStack = this.scopes[$_get](this.stackSize - 1);
      if (peekStack === 1) {
        this.scopes[$_set](this.stackSize - 1, 2);
      } else if (peekStack === 2) {
        let c = this[_nextNonWhitespace](true);
        this.buffer.readByte();
        switch (c) {
          case 93:
            {
              return this[_peeked] = 4;
            }
          case 59:
            {
              this[_checkLenient]();
              break;
            }
          case 44:
            {
              break;
            }
          default:
            {
              dart.throw(this.syntaxError("Unterminated array"));
            }
        }
      } else if (peekStack === 3 || peekStack === 5) {
        this.scopes[$_set](this.stackSize - 1, 4);
        if (peekStack === 5) {
          let c = this[_nextNonWhitespace](true);
          this.buffer.readByte();
          switch (c) {
            case 125:
              {
                return this[_peeked] = 2;
              }
            case 59:
              {
                this[_checkLenient]();
                break;
              }
            case 44:
              {
                break;
              }
            default:
              {
                dart.throw(this.syntaxError("Unterminated object"));
              }
          }
        }
        let c = this[_nextNonWhitespace](true);
        switch (c) {
          case 34:
            {
              this.buffer.readByte();
              return this[_peeked] = 13;
            }
          case 39:
            {
              this.buffer.readByte();
              this[_checkLenient]();
              return this[_peeked] = 12;
            }
          case 125:
            {
              if (peekStack !== 5) {
                this.buffer.readByte();
                return this[_peeked] = 2;
              }
              dart.throw(this.syntaxError("Expected name"));
            }
          default:
            {
              this[_checkLenient]();
              if (this.isLiteral(c)) {
                return this[_peeked] = 14;
              } else {
                dart.throw(this.syntaxError("Expected name"));
              }
            }
        }
      } else if (peekStack === 4) {
        this.scopes[$_set](this.stackSize - 1, 5);
        let c = this[_nextNonWhitespace](true);
        this.buffer.readByte();
        switch (c) {
          case 58:
            {
              break;
            }
          case 61:
            {
              this[_checkLenient]();
              if (this.buffer.request(1) && this.buffer.getByte(0) === 62) {
                this.buffer.readByte();
              }
              break;
            }
          default:
            {
              dart.throw(this.syntaxError("Expected ':'"));
            }
        }
      } else if (peekStack === 6) {
        this.scopes[$_set](this.stackSize - 1, 7);
      } else if (peekStack === 7) {
        let c = this[_nextNonWhitespace](false);
        if (c === -1) {
          return this[_peeked] = 18;
        } else {
          this[_checkLenient]();
        }
      } else if (peekStack === 8) {
        dart.throw(new core.StateError.new("JsonReader is closed"));
      }
      let c = this[_nextNonWhitespace](true);
      switch (c) {
        case 93:
        case 59:
        case 44:
          {
            if (c === 93) {
              if (peekStack === 1) {
                this.buffer.readByte();
                return this[_peeked] = 4;
              }
            }
            if (peekStack === 1 || peekStack === 2) {
              this[_checkLenient]();
              return this[_peeked] = 7;
            } else {
              dart.throw(this.syntaxError("Unexpected value"));
            }
          }
        case 39:
          {
            this[_checkLenient]();
            this.buffer.readByte();
            return this[_peeked] = 8;
          }
        case 34:
          {
            this.buffer.readByte();
            return this[_peeked] = 9;
          }
        case 91:
          {
            this.buffer.readByte();
            return this[_peeked] = 3;
          }
        case 123:
          {
            this.buffer.readByte();
            return this[_peeked] = 1;
          }
        default:
      }
      let result = this.peekKeyword();
      if (result !== 0) {
        return result;
      }
      result = this.peekNumber();
      if (result !== 0) {
        return result;
      }
      if (!this.isLiteral(this.buffer.getByte(0))) {
        dart.throw(this.syntaxError("Expected value"));
      }
      this[_checkLenient]();
      return this[_peeked] = 10;
    }
    peekKeyword() {
      let c = this.buffer.getByte(0);
      let keyword = null;
      let keywordUpper = null;
      let peeking = null;
      if (c === 116 || c === 84) {
        keyword = "true";
        keywordUpper = "TRUE";
        peeking = 5;
      } else if (c === 102 || c === 70) {
        keyword = "false";
        keywordUpper = "FALSE";
        peeking = 6;
      } else if (c === 110 || c === 78) {
        keyword = "null";
        keywordUpper = "NULL";
        peeking = 7;
      } else {
        return 0;
      }
      let length = keyword.length;
      for (let i = 1; i < length; i = i + 1) {
        if (!this.buffer.request(i + 1)) {
          return 0;
        }
        c = this.buffer.getByte(i);
        if (c !== keyword[$_get](i)[$codeUnitAt](0) && c !== keywordUpper[$_get](i)[$codeUnitAt](0)) {
          return 0;
        }
      }
      if (this.buffer.request(length + 1) && this.isLiteral(this.buffer.getByte(length))) {
        return 0;
      }
      this.buffer.skip(length);
      return this[_peeked] = peeking;
    }
    peekNumber() {
      let value = 0;
      let negative = false;
      let fitsInLong = true;
      let last = 0;
      let i = 0;
      for (; true; i = i + 1) {
        if (!this.buffer.request(i + 1)) {
          break;
        }
        let c = this.buffer.getByte(i);
        if (c === 45) {
          if (last === 0) {
            negative = true;
            last = 1;
            continue;
          } else if (last === 5) {
            last = 6;
            continue;
          }
          return 0;
        } else if (c === 43) {
          if (last === 5) {
            last = 6;
            continue;
          }
          return 0;
        } else if (c === 101 || c === 69) {
          if (last === 2 || last === 4) {
            last = 5;
            continue;
          }
          return 0;
        } else if (c === 46) {
          if (last === 2) {
            last = 3;
            continue;
          }
          return 0;
        } else {
          if (c < 48 || c > 57) {
            if (!this.isLiteral(c)) {
              break;
            }
            return 0;
          }
          if (last === 1 || last === 0) {
            value = -(c - 48);
            last = 2;
          } else if (last === 2) {
            if (value === 0) {
              return 0;
            }
            let newValue = value * 10 - (c - 48);
            fitsInLong = !!(fitsInLong & (value > -900719925474099.0 || value === -900719925474099.0 && newValue < value));
            value = newValue;
          } else if (last === 3) {
            last = 4;
          } else if (last === 5 || last === 6) {
            last = 7;
          }
        }
      }
      if (last === 2 && fitsInLong && (value !== -9007199254740991.0 || negative) && (value !== 0 || !negative)) {
        this[_peekedLong] = negative ? value : -value;
        this.buffer.skip(i);
        return this[_peeked] = 16;
      } else if (last === 2 || last === 4 || last === 7) {
        this[_peekedNumberLength] = i;
        return this[_peeked] = 17;
      } else {
        return 0;
      }
    }
    isLiteral(c) {
      switch (c) {
        case 47:
        case 92:
        case 59:
        case 35:
        case 61:
          {
            this[_checkLenient]();
            return false;
          }
        case 123:
        case 125:
        case 91:
        case 93:
        case 58:
        case 44:
        case 32:
        case 9:
        case 12:
        case 13:
        case 10:
          {
            return false;
          }
        default:
          {
            return true;
          }
      }
    }
    nextName() {
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      let result = null;
      function result$35get() {
        let t1;
        t1 = result;
        return t1 == null ? dart.throw(new _internal.LateError.localNI("result")) : t1;
      }
      dart.fn(result$35get, T.VoidToString());
      function result$35set(result$35param) {
        return result = result$35param;
      }
      dart.fn(result$35set, T.StringTodynamic());
      if (p === 14) {
        result$35set(this.nextUnquotedValue());
      } else if (p === 13) {
        result$35set(this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash));
      } else if (p === 12) {
        result$35set(this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash));
      } else if (p === 15) {
        result$35set(dart.nullCheck(this[_peekedString]));
      } else {
        dart.throw(new json_reader.JsonDataException.new("Expected a name but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
      this[_peeked] = 0;
      this.pathNames[$_set](this.stackSize - 1, result$35get());
      return result$35get();
    }
    selectName(options) {
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p < 12 || p > 15) {
        return -1;
      }
      if (p === 15) {
        return this[_findName](this[_peekedString], options);
      }
      let result = this.buffer.select(options.doubleQuoteSuffix);
      if (result !== -1) {
        this[_peeked] = 0;
        this.pathNames[$_set](this.stackSize - 1, options.strings[$_get](result));
        return result;
      }
      let lastPathName = this.pathNames[$_get](this.stackSize - 1);
      let nextName = this.nextName();
      result = this[_findName](nextName, options);
      if (result === -1) {
        this[_peeked] = 15;
        this[_peekedString] = nextName;
        this.pathNames[$_set](this.stackSize - 1, lastPathName);
      }
      return result;
    }
    skipName() {
      if (this.failOnUnknown) {
        dart.throw(new json_reader.JsonDataException.new("Cannot skip unexpected " + dart.str(this.peek()) + " at " + this.getPath()));
      }
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 14) {
        this.skipUnquotedValue();
      } else if (p === 13) {
        this.skipQuotedValue(json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash);
      } else if (p === 12) {
        this.skipQuotedValue(json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash);
      } else if (p !== 15) {
        dart.throw(new json_reader.JsonDataException.new("Expected a name but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
      this[_peeked] = 0;
      this.pathNames[$_set](this.stackSize - 1, "null");
    }
    [_findName](name, options) {
      for (let i = 0, size = options.strings[$length]; i < size; i = i + 1) {
        if (name === options.strings[$_get](i)) {
          this[_peeked] = 0;
          this.pathNames[$_set](this.stackSize - 1, name);
          return i;
        }
      }
      return -1;
    }
    nextString() {
      let t4, t3;
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      let result = null;
      if (p === 10) {
        result = this.nextUnquotedValue();
      } else if (p === 9) {
        result = this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash);
      } else if (p === 8) {
        result = this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash);
      } else if (p === 11) {
        result = this[_peekedString];
        this[_peekedString] = null;
      } else if (p === 16) {
        result = this[_peekedLong][$toString]();
      } else if (p === 17) {
        result = this.buffer.readUtf8(this[_peekedNumberLength]);
      } else {
        dart.throw(new json_reader.JsonDataException.new("Expected a string but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
      this[_peeked] = 0;
      t3 = this.pathIndices;
      t4 = this.stackSize - 1;
      t3[$_set](t4, t3[$_get](t4) + 1);
      return dart.nullCheck(result);
    }
    nextBoolean() {
      let t4, t3, t4$, t3$;
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 5) {
        this[_peeked] = 0;
        t3 = this.pathIndices;
        t4 = this.stackSize - 1;
        t3[$_set](t4, t3[$_get](t4) + 1);
        return true;
      } else if (p === 6) {
        this[_peeked] = 0;
        t3$ = this.pathIndices;
        t4$ = this.stackSize - 1;
        t3$[$_set](t4$, t3$[$_get](t4$) + 1);
        return false;
      }
      dart.throw(new json_reader.JsonDataException.new("Expected a boolean but was " + dart.str(this.peek()) + " at path " + this.getPath()));
    }
    nextDouble() {
      let t4, t3, t5, t4$;
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      if (p === 16) {
        this[_peeked] = 0;
        t3 = this.pathIndices;
        t4 = this.stackSize - 1;
        t3[$_set](t4, t3[$_get](t4) + 1);
        return this[_peekedLong][$toDouble]();
      }
      if (p === 17) {
        this[_peekedString] = this.buffer.readUtf8(this[_peekedNumberLength]);
      } else if (p === 9) {
        this[_peekedString] = this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash);
      } else if (p === 8) {
        this[_peekedString] = this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash);
      } else if (p === 10) {
        this[_peekedString] = this.nextUnquotedValue();
      } else if (p !== 11) {
        dart.throw(new json_reader.JsonDataException.new("Expected a double but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
      this[_peeked] = 11;
      let result = null;
      try {
        result = core.double.parse(dart.nullCheck(this[_peekedString]));
      } catch (e) {
        let _ = dart.getThrown(e);
        if (core.FormatException.is(_)) {
          dart.throw(new json_reader.JsonDataException.new("Expected a double but was " + dart.str(this[_peekedString]) + " at path " + this.getPath()));
        } else
          throw e;
      }
      if (!this.lenient && (result[$isNaN] || result[$isInfinite])) {
        dart.throw(new json_reader.JsonEncodingException.new("JSON forbids NaN and infinities: " + dart.str(result) + " at path " + this.getPath()));
      }
      this[_peekedString] = null;
      this[_peeked] = 0;
      t4$ = this.pathIndices;
      t5 = this.stackSize - 1;
      t4$[$_set](t5, t4$[$_get](t5) + 1);
      return result;
    }
    [_nextQuotedValue](runTerminator) {
      let builder = null;
      while (true) {
        let index = this.buffer.indexOfElement(runTerminator, 0);
        if (index === -1) dart.throw(this.syntaxError("Unterminated string"));
        if (this.buffer.getByte(index) === 92) {
          builder == null ? builder = new core.StringBuffer.new() : null;
          builder.write(this.buffer.readUtf8(index));
          this.buffer.readByte();
          builder.writeCharCode(this.readEscapeCharacter());
          continue;
        }
        if (builder == null) {
          let result = this.buffer.readUtf8(index);
          this.buffer.readByte();
          return result;
        } else {
          builder.write(this.buffer.readUtf8(index));
          this.buffer.readByte();
          return dart.toString(builder);
        }
      }
    }
    nextUnquotedValue() {
      let i = this.buffer.indexOfElement(json_utf8_reader.JsonUtf8Reader.unquotedStringTerminals, 0);
      return i !== -1 ? this.buffer.readUtf8(i) : this.buffer.readUtf8(this.buffer.size);
    }
    skipQuotedValue(runTerminator) {
      while (true) {
        let index = this.buffer.indexOfElement(runTerminator, 0);
        if (index === -1) dart.throw(this.syntaxError("Unterminated string"));
        if (this.buffer.getByte(index) === 92) {
          this.buffer.skip(index + 1);
          this.readEscapeCharacter();
        } else {
          this.buffer.skip(index + 1);
          return;
        }
      }
    }
    skipUnquotedValue() {
      let i = this.buffer.indexOfElement(json_utf8_reader.JsonUtf8Reader.unquotedStringTerminals, 0);
      this.buffer.skip(i !== -1 ? i : this.buffer.size);
    }
    nextInt() {
      let t5, t4, t5$, t4$, t7, t6;
      let p = this[_peeked];
      if (p === 0) {
        p = this[_doPeek]();
      }
      let result = null;
      if (p === 16) {
        result = this[_peekedLong];
        if (this[_peekedLong] !== result) {
          dart.throw(new json_reader.JsonDataException.new("Expected an int but was " + dart.str(this[_peekedLong]) + " at path " + this.getPath()));
        }
        this[_peeked] = 0;
        t4 = this.pathIndices;
        t5 = this.stackSize - 1;
        t4[$_set](t5, t4[$_get](t5) + 1);
        return result;
      }
      if (p === 17) {
        this[_peekedString] = this.buffer.readUtf8(this[_peekedNumberLength]);
      } else if (p === 9 || p === 8) {
        this[_peekedString] = p === 9 ? this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash) : this[_nextQuotedValue](json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash);
        try {
          result = core.int.parse(dart.nullCheck(this[_peekedString]));
          this[_peeked] = 0;
          t4$ = this.pathIndices;
          t5$ = this.stackSize - 1;
          t4$[$_set](t5$, t4$[$_get](t5$) + 1);
          return result;
        } catch (e) {
          let _ = dart.getThrown(e);
          if (core.FormatException.is(_)) {
          } else
            throw e;
        }
      } else if (p !== 11) {
        dart.throw(new json_reader.JsonDataException.new("Expected an int but was " + dart.str(this.peek()) + " at path " + this.getPath()));
      }
      this[_peeked] = 11;
      let asDouble = null;
      try {
        asDouble = core.double.parse(dart.nullCheck(this[_peekedString]));
      } catch (e$) {
        let _ = dart.getThrown(e$);
        if (core.FormatException.is(_)) {
          dart.throw(new json_reader.JsonDataException.new("Expected an int but was " + dart.str(this[_peekedString]) + "  at path " + this.getPath()));
        } else
          throw e$;
      }
      result = asDouble[$toInt]();
      if (result !== asDouble) {
        dart.throw(new json_reader.JsonDataException.new("Expected an int but was " + dart.str(this[_peekedString]) + " at path " + this.getPath()));
      }
      this[_peekedString] = null;
      this[_peeked] = 0;
      t6 = this.pathIndices;
      t7 = this.stackSize - 1;
      t6[$_set](t7, t6[$_get](t7) + 1);
      return result;
    }
    close() {
      this[_peeked] = 0;
      this.scopes[$_set](0, 8);
      this.stackSize = 1;
      this.buffer.clear();
    }
    skipValue() {
      let t7, t6;
      if (this.failOnUnknown) {
        dart.throw(new json_reader.JsonDataException.new("Cannot skip unexpected " + dart.str(this.peek()) + " at " + this.getPath()));
      }
      let count = 0;
      do {
        let p = this[_peeked];
        if (p === 0) {
          p = this[_doPeek]();
        }
        if (p === 3) {
          this.pushScope(1);
          count = count + 1;
        } else if (p === 1) {
          this.pushScope(3);
          count = count + 1;
        } else if (p === 4) {
          count = count - 1;
          if (count < 0) {
            dart.throw(new json_reader.JsonDataException.new("Expected a value but was " + dart.str(this.peek()) + " at path " + this.getPath()));
          }
          this.stackSize = this.stackSize - 1;
        } else if (p === 2) {
          count = count - 1;
          if (count < 0) {
            dart.throw(new json_reader.JsonDataException.new("Expected a value but was " + dart.str(this.peek()) + " at path " + this.getPath()));
          }
          this.stackSize = this.stackSize - 1;
        } else if (p === 14 || p === 10) {
          this.skipUnquotedValue();
        } else if (p === 9 || p === 13) {
          this.skipQuotedValue(json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash);
        } else if (p === 8 || p === 12) {
          this.skipQuotedValue(json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash);
        } else if (p === 17) {
          this.buffer.skip(this[_peekedNumberLength]);
        } else if (p === 18) {
          dart.throw(new json_reader.JsonDataException.new("Expected a value but was " + dart.str(this.peek()) + " at path " + this.getPath()));
        }
        this[_peeked] = 0;
      } while (count !== 0);
      t6 = this.pathIndices;
      t7 = this.stackSize - 1;
      t6[$_set](t7, t6[$_get](t7) + 1);
      this.pathNames[$_set](this.stackSize - 1, "null");
    }
    [_nextNonWhitespace](throwOnEof) {
      let t6;
      let p = 0;
      while (this.buffer.request(p + 1)) {
        let c = this.buffer.getByte((t6 = p, p = t6 + 1, t6));
        if (c === 10 || c === 32 || c === 13 || c === 9) {
          continue;
        }
        this.buffer.skip(p - 1);
        if (c === 47) {
          if (!this.buffer.request(2)) {
            return c;
          }
          this[_checkLenient]();
          let peek = this.buffer.getByte(1);
          switch (peek) {
            case 42:
              {
                this.buffer.readByte();
                this.buffer.readByte();
                if (!this[_skipToEndOfBlockComment]()) {
                  dart.throw(this.syntaxError("Unterminated comment"));
                }
                p = 0;
                continue;
              }
            case 47:
              {
                this.buffer.readByte();
                this.buffer.readByte();
                this[_skipToEndOfLine]();
                p = 0;
                continue;
              }
            default:
              {
                return c;
              }
          }
        } else if (c === 35) {
          this[_checkLenient]();
          this[_skipToEndOfLine]();
          p = 0;
        } else {
          return c;
        }
      }
      if (throwOnEof) {
        dart.throw(new core.StateError.new("End of input"));
      } else {
        return -1;
      }
    }
    [_checkLenient]() {
      if (!this.lenient) {
        dart.throw(this.syntaxError("Use JsonReader.setLenient(true) to accept malformed JSON"));
      }
    }
    [_skipToEndOfLine]() {
      let index = this.buffer.indexOfElement(json_utf8_reader.JsonUtf8Reader.lineFeedOrCarriageReturn, 0);
      this.buffer.skip(index !== -1 ? index + 1 : this.buffer.size);
    }
    [_skipToEndOfBlockComment]() {
      let index = this.buffer.indexOfBytes(json_utf8_reader.JsonUtf8Reader.closingBlockComment, 0);
      let found = index !== -1;
      this.buffer.skip(found ? index + json_utf8_reader.JsonUtf8Reader.closingBlockComment[$length] : this.buffer.size);
      return found;
    }
    toString() {
      return "JsonReader(" + dart.str(this.buffer) + ")";
    }
    readEscapeCharacter() {
      if (!this.buffer.request(1)) {
        dart.throw(this.syntaxError("Unterminated escape sequence"));
      }
      let escaped = this.buffer.readByte();
      switch (escaped) {
        case 117:
          {
            if (!this.buffer.request(4)) {
              dart.throw(core.Exception.new("Unterminated escape sequence at path " + this.getPath()));
            }
            let result = 0;
            for (let i = 0, end = i + 4; i < end; i = i + 1) {
              let c = this.buffer.getByte(i);
              result = result << 4 >>> 0;
              if (c >= 48 && c <= 57) {
                result = result + (c - 48);
              } else if (c >= 97 && c <= 102) {
                result = result + (c - 97 + 10);
              } else if (c >= 65 && c <= 70) {
                result = result + (c - 65 + 10);
              } else {
                dart.throw(this.syntaxError("\\u" + this.buffer.readUtf8(4)));
              }
            }
            this.buffer.skip(4);
            return result;
          }
        case 116:
          {
            return 9;
          }
        case 98:
          {
            return 8;
          }
        case 110:
          {
            return 10;
          }
        case 114:
          {
            return 13;
          }
        case 102:
          {
            return 12;
          }
        case 10:
        case 39:
        case 34:
        case 92:
        case 47:
          {
            return escaped;
          }
        default:
          {
            if (!this.lenient) dart.throw(this.syntaxError("Invalid escape sequence: \\" + dart.str(escaped)));
            return escaped;
          }
      }
    }
  };
  (json_utf8_reader.JsonUtf8Reader.new = function(buffer) {
    this[_peeked] = 0;
    this[__JsonUtf8Reader__peekedLong] = null;
    this[__JsonUtf8Reader__peekedNumberLength] = null;
    this[_peekedString] = null;
    this[buffer$] = buffer;
    json_utf8_reader.JsonUtf8Reader.__proto__.new.call(this);
    this.pushScope(6);
  }).prototype = json_utf8_reader.JsonUtf8Reader.prototype;
  dart.addTypeTests(json_utf8_reader.JsonUtf8Reader);
  dart.addTypeCaches(json_utf8_reader.JsonUtf8Reader);
  dart.setMethodSignature(json_utf8_reader.JsonUtf8Reader, () => ({
    __proto__: dart.getMethods(json_utf8_reader.JsonUtf8Reader.__proto__),
    beginArray: dart.fnType(dart.void, []),
    endArray: dart.fnType(dart.void, []),
    beginObject: dart.fnType(dart.void, []),
    endObject: dart.fnType(dart.void, []),
    hasNext: dart.fnType(core.bool, []),
    peek: dart.fnType(json_reader.Token, []),
    [_doPeek]: dart.fnType(core.int, []),
    peekKeyword: dart.fnType(core.int, []),
    peekNumber: dart.fnType(core.int, []),
    isLiteral: dart.fnType(core.bool, [core.int]),
    nextName: dart.fnType(core.String, []),
    selectName: dart.fnType(core.int, [json_reader.JsonReaderOptions]),
    skipName: dart.fnType(dart.void, []),
    [_findName]: dart.fnType(core.int, [dart.nullable(core.String), json_reader.JsonReaderOptions]),
    nextString: dart.fnType(core.String, []),
    nextBoolean: dart.fnType(core.bool, []),
    nextDouble: dart.fnType(core.double, []),
    [_nextQuotedValue]: dart.fnType(core.String, [core.List$(core.int)]),
    nextUnquotedValue: dart.fnType(core.String, []),
    skipQuotedValue: dart.fnType(dart.void, [core.List$(core.int)]),
    skipUnquotedValue: dart.fnType(dart.void, []),
    nextInt: dart.fnType(core.int, []),
    close: dart.fnType(dart.void, []),
    skipValue: dart.fnType(dart.void, []),
    [_nextNonWhitespace]: dart.fnType(core.int, [core.bool]),
    [_checkLenient]: dart.fnType(dart.void, []),
    [_skipToEndOfLine]: dart.fnType(dart.void, []),
    [_skipToEndOfBlockComment]: dart.fnType(core.bool, []),
    readEscapeCharacter: dart.fnType(core.int, [])
  }));
  dart.setGetterSignature(json_utf8_reader.JsonUtf8Reader, () => ({
    __proto__: dart.getGetters(json_utf8_reader.JsonUtf8Reader.__proto__),
    [_peekedLong]: core.int,
    [_peekedNumberLength]: core.int
  }));
  dart.setSetterSignature(json_utf8_reader.JsonUtf8Reader, () => ({
    __proto__: dart.getSetters(json_utf8_reader.JsonUtf8Reader.__proto__),
    [_peekedLong]: core.int,
    [_peekedNumberLength]: core.int
  }));
  dart.setLibraryUri(json_utf8_reader.JsonUtf8Reader, I[1]);
  dart.setFieldSignature(json_utf8_reader.JsonUtf8Reader, () => ({
    __proto__: dart.getFields(json_utf8_reader.JsonUtf8Reader.__proto__),
    buffer: dart.finalFieldType(buffer.Buffer),
    [_peeked]: dart.fieldType(core.int),
    [__JsonUtf8Reader__peekedLong]: dart.fieldType(dart.nullable(core.int)),
    [__JsonUtf8Reader__peekedNumberLength]: dart.fieldType(dart.nullable(core.int)),
    [_peekedString]: dart.fieldType(dart.nullable(core.String))
  }));
  dart.setStaticFieldSignature(json_utf8_reader.JsonUtf8Reader, () => ['longMinValue', 'minIncompleteInteger', 'singleQuoteOrSlash', 'doubleQuoteOrSlash', 'unquotedStringTerminals', 'lineFeedOrCarriageReturn', 'closingBlockComment', 'peekedNone', 'peekedBeginObject', 'peekedEndObject', 'peekedBeginArray', 'peekedEndArray', 'peekedTrue', 'peekedFalse', 'peekedNull', 'peekedSingleQuote', 'peekedDoubleQuote', 'peekedUnquoted', 'peekedBuffered', 'peekedSingleQuotedName', 'peekedDoubleQuotedName', 'peekedUnquotedName', 'peekedBufferedName', 'peekedLong', 'peekedNumber', 'peekedEof', 'numberCharNone', 'numberCharSign', 'numberCharDigit', 'numberCharDecimal', 'numberCharFractionDigit', 'numberCharExpE', 'numberCharExpSign', 'numberCharExpDigit']);
  dart.defineExtensionMethods(json_utf8_reader.JsonUtf8Reader, ['toString']);
  dart.defineLazy(json_utf8_reader.JsonUtf8Reader, {
    /*json_utf8_reader.JsonUtf8Reader.longMinValue*/get longMinValue() {
      return -9007199254740991.0;
    },
    /*json_utf8_reader.JsonUtf8Reader.minIncompleteInteger*/get minIncompleteInteger() {
      return -900719925474099.0;
    },
    /*json_utf8_reader.JsonUtf8Reader.singleQuoteOrSlash*/get singleQuoteOrSlash() {
      return convert.utf8.encode("'\\");
    },
    /*json_utf8_reader.JsonUtf8Reader.doubleQuoteOrSlash*/get doubleQuoteOrSlash() {
      return convert.utf8.encode("\"\\");
    },
    /*json_utf8_reader.JsonUtf8Reader.unquotedStringTerminals*/get unquotedStringTerminals() {
      return convert.utf8.encode("{}[]:, \n\t\r\f/\\;#=");
    },
    /*json_utf8_reader.JsonUtf8Reader.lineFeedOrCarriageReturn*/get lineFeedOrCarriageReturn() {
      return convert.utf8.encode("\n\r");
    },
    /*json_utf8_reader.JsonUtf8Reader.closingBlockComment*/get closingBlockComment() {
      return convert.utf8.encode("*/");
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedNone*/get peekedNone() {
      return 0;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedBeginObject*/get peekedBeginObject() {
      return 1;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedEndObject*/get peekedEndObject() {
      return 2;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedBeginArray*/get peekedBeginArray() {
      return 3;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedEndArray*/get peekedEndArray() {
      return 4;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedTrue*/get peekedTrue() {
      return 5;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedFalse*/get peekedFalse() {
      return 6;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedNull*/get peekedNull() {
      return 7;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedSingleQuote*/get peekedSingleQuote() {
      return 8;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedDoubleQuote*/get peekedDoubleQuote() {
      return 9;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedUnquoted*/get peekedUnquoted() {
      return 10;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedBuffered*/get peekedBuffered() {
      return 11;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedSingleQuotedName*/get peekedSingleQuotedName() {
      return 12;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedDoubleQuotedName*/get peekedDoubleQuotedName() {
      return 13;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedUnquotedName*/get peekedUnquotedName() {
      return 14;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedBufferedName*/get peekedBufferedName() {
      return 15;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedLong*/get peekedLong() {
      return 16;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedNumber*/get peekedNumber() {
      return 17;
    },
    /*json_utf8_reader.JsonUtf8Reader.peekedEof*/get peekedEof() {
      return 18;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharNone*/get numberCharNone() {
      return 0;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharSign*/get numberCharSign() {
      return 1;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharDigit*/get numberCharDigit() {
      return 2;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharDecimal*/get numberCharDecimal() {
      return 3;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharFractionDigit*/get numberCharFractionDigit() {
      return 4;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharExpE*/get numberCharExpE() {
      return 5;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharExpSign*/get numberCharExpSign() {
      return 6;
    },
    /*json_utf8_reader.JsonUtf8Reader.numberCharExpDigit*/get numberCharExpDigit() {
      return 7;
    }
  }, false);
  var strings$ = dart.privateName(json_reader, "JsonReaderOptions.strings");
  var doubleQuoteSuffix$ = dart.privateName(json_reader, "JsonReaderOptions.doubleQuoteSuffix");
  json_reader.JsonReaderOptions = class JsonReaderOptions extends core.Object {
    get strings() {
      return this[strings$];
    }
    set strings(value) {
      super.strings = value;
    }
    get doubleQuoteSuffix() {
      return this[doubleQuoteSuffix$];
    }
    set doubleQuoteSuffix(value) {
      super.doubleQuoteSuffix = value;
    }
    static ['_#new#tearOff'](strings, doubleQuoteSuffix) {
      return new json_reader.JsonReaderOptions.new(strings, doubleQuoteSuffix);
    }
    static of(strings) {
      return new json_reader.JsonReaderOptions.new(strings, strings[$map](T.ListOfint(), dart.fn(s => convert.utf8.encode(s + "\""), T.StringToListOfint()))[$toList]());
    }
  };
  (json_reader.JsonReaderOptions.new = function(strings, doubleQuoteSuffix) {
    this[strings$] = strings;
    this[doubleQuoteSuffix$] = doubleQuoteSuffix;
    ;
  }).prototype = json_reader.JsonReaderOptions.prototype;
  dart.addTypeTests(json_reader.JsonReaderOptions);
  dart.addTypeCaches(json_reader.JsonReaderOptions);
  dart.setStaticMethodSignature(json_reader.JsonReaderOptions, () => ['of']);
  dart.setLibraryUri(json_reader.JsonReaderOptions, I[0]);
  dart.setFieldSignature(json_reader.JsonReaderOptions, () => ({
    __proto__: dart.getFields(json_reader.JsonReaderOptions.__proto__),
    strings: dart.finalFieldType(core.List$(core.String)),
    doubleQuoteSuffix: dart.finalFieldType(core.List$(core.List$(core.int)))
  }));
  var _name = dart.privateName(core, "_name");
  var _Enum__name = dart.privateName(core, "_Enum._name");
  var _Enum_index = dart.privateName(core, "_Enum.index");
  json_reader.Token = class Token extends core._Enum {
    toString() {
      return "Token." + this[_name];
    }
  };
  (json_reader.Token.new = function(index, name) {
    json_reader.Token.__proto__.new.call(this, index, name);
    ;
  }).prototype = json_reader.Token.prototype;
  dart.addTypeTests(json_reader.Token);
  dart.addTypeCaches(json_reader.Token);
  dart.setLibraryUri(json_reader.Token, I[0]);
  dart.setStaticFieldSignature(json_reader.Token, () => ['values', 'beginArray', 'endArray', 'beginObject', 'endObject', 'name_', 'string', 'number', 'boolean', 'nullToken', 'endDocument']);
  dart.defineExtensionMethods(json_reader.Token, ['toString']);
  dart.defineLazy(json_reader.Token, {
    /*json_reader.Token.values*/get values() {
      return C[0] || CT.C0;
    },
    /*json_reader.Token.beginArray*/get beginArray() {
      return C[1] || CT.C1;
    },
    /*json_reader.Token.endArray*/get endArray() {
      return C[2] || CT.C2;
    },
    /*json_reader.Token.beginObject*/get beginObject() {
      return C[3] || CT.C3;
    },
    /*json_reader.Token.endObject*/get endObject() {
      return C[4] || CT.C4;
    },
    /*json_reader.Token.name_*/get name_() {
      return C[5] || CT.C5;
    },
    /*json_reader.Token.string*/get string() {
      return C[6] || CT.C6;
    },
    /*json_reader.Token.number*/get number() {
      return C[7] || CT.C7;
    },
    /*json_reader.Token.boolean*/get boolean() {
      return C[8] || CT.C8;
    },
    /*json_reader.Token.nullToken*/get nullToken() {
      return C[9] || CT.C9;
    },
    /*json_reader.Token.endDocument*/get endDocument() {
      return C[10] || CT.C10;
    }
  }, false);
  var message$ = dart.privateName(json_reader, "JsonDataException.message");
  json_reader.JsonDataException = class JsonDataException extends core.Object {
    get message() {
      return this[message$];
    }
    set message(value) {
      super.message = value;
    }
    static ['_#new#tearOff'](message) {
      return new json_reader.JsonDataException.new(message);
    }
    toString() {
      return this.message;
    }
  };
  (json_reader.JsonDataException.new = function(message) {
    this[message$] = message;
    ;
  }).prototype = json_reader.JsonDataException.prototype;
  dart.addTypeTests(json_reader.JsonDataException);
  dart.addTypeCaches(json_reader.JsonDataException);
  json_reader.JsonDataException[dart.implements] = () => [core.Exception];
  dart.setLibraryUri(json_reader.JsonDataException, I[0]);
  dart.setFieldSignature(json_reader.JsonDataException, () => ({
    __proto__: dart.getFields(json_reader.JsonDataException.__proto__),
    message: dart.finalFieldType(core.String)
  }));
  dart.defineExtensionMethods(json_reader.JsonDataException, ['toString']);
  var message$0 = dart.privateName(json_reader, "JsonEncodingException.message");
  json_reader.JsonEncodingException = class JsonEncodingException extends core.Object {
    get message() {
      return this[message$0];
    }
    set message(value) {
      super.message = value;
    }
    static ['_#new#tearOff'](message) {
      return new json_reader.JsonEncodingException.new(message);
    }
    toString() {
      return this.message;
    }
  };
  (json_reader.JsonEncodingException.new = function(message) {
    this[message$0] = message;
    ;
  }).prototype = json_reader.JsonEncodingException.prototype;
  dart.addTypeTests(json_reader.JsonEncodingException);
  dart.addTypeCaches(json_reader.JsonEncodingException);
  json_reader.JsonEncodingException[dart.implements] = () => [core.Exception];
  dart.setLibraryUri(json_reader.JsonEncodingException, I[0]);
  dart.setFieldSignature(json_reader.JsonEncodingException, () => ({
    __proto__: dart.getFields(json_reader.JsonEncodingException.__proto__),
    message: dart.finalFieldType(core.String)
  }));
  dart.defineExtensionMethods(json_reader.JsonEncodingException, ['toString']);
  dart.trackLibraries("packages/lottie/src/parser/moshi/json_utf8_reader.dart", {
    "package:lottie/src/parser/moshi/json_utf8_reader.dart": json_utf8_reader,
    "package:lottie/src/parser/moshi/json_reader.dart": json_reader
  }, {
  }, '{"version":3,"sourceRoot":"","sources":["json_reader.dart","json_utf8_reader.dart"],"names":[],"mappings":"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","file":"../../../../../../../../../../../../../packages/lottie/src/parser/moshi/json_utf8_reader.dart.lib.js"}');
  // Exports:
  return {
    src__parser__moshi__json_utf8_reader: json_utf8_reader,
    src__parser__moshi__json_reader: json_reader
  };
}));

//# sourceMappingURL=json_utf8_reader.dart.lib.js.map

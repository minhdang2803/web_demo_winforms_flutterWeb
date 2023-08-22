define(['dart_sdk'], (function load__packages__collection__src__canonicalized_map_dart(dart_sdk) {
  'use strict';
  const core = dart_sdk.core;
  const _js_helper = dart_sdk._js_helper;
  const collection = dart_sdk.collection;
  const dart = dart_sdk.dart;
  const dartx = dart_sdk.dartx;
  var canonicalized_map = Object.create(dart.library);
  var $_get = dartx._get;
  var $_set = dartx._set;
  var $forEach = dartx.forEach;
  var $map = dartx.map;
  var $addEntries = dartx.addEntries;
  var $cast = dartx.cast;
  var $clear = dartx.clear;
  var $containsKey = dartx.containsKey;
  var $values = dartx.values;
  var $any = dartx.any;
  var $entries = dartx.entries;
  var $isEmpty = dartx.isEmpty;
  var $isNotEmpty = dartx.isNotEmpty;
  var $length = dartx.length;
  var $putIfAbsent = dartx.putIfAbsent;
  var $remove = dartx.remove;
  var $removeWhere = dartx.removeWhere;
  var $update = dartx.update;
  var $updateAll = dartx.updateAll;
  var $addAll = dartx.addAll;
  var $containsValue = dartx.containsValue;
  var $keys = dartx.keys;
  dart._checkModuleNullSafetyMode(true);
  dart._checkModuleRuntimeTypes(false);
  const CT = Object.create({
    _: () => (C, CT)
  });
  var I = ["package:collection/src/canonicalized_map.dart"];
  var _base = dart.privateName(canonicalized_map, "_base");
  var _canonicalize = dart.privateName(canonicalized_map, "_canonicalize");
  var _isValidKeyFn = dart.privateName(canonicalized_map, "_isValidKeyFn");
  var _isValidKey = dart.privateName(canonicalized_map, "_isValidKey");
  const _is_CanonicalizedMap_default = Symbol('_is_CanonicalizedMap_default');
  canonicalized_map.CanonicalizedMap$ = dart.generic((C, K, V) => {
    var __t$LinkedMapOfC$MapEntryOfK$V = () => (__t$LinkedMapOfC$MapEntryOfK$V = dart.constFn(_js_helper.LinkedMap$(C, __t$MapEntryOfK$V())))();
    var __t$MapEntryOfC$MapEntryOfK$V = () => (__t$MapEntryOfC$MapEntryOfK$V = dart.constFn(core.MapEntry$(C, __t$MapEntryOfK$V())))();
    var __t$MapEntryOfK$VToMapEntryOfC$MapEntryOfK$V = () => (__t$MapEntryOfK$VToMapEntryOfC$MapEntryOfK$V = dart.constFn(dart.fnType(__t$MapEntryOfC$MapEntryOfK$V(), [__t$MapEntryOfK$V()])))();
    var __t$MapEntryOfC$MapEntryOfK$VToMapEntryOfK$V = () => (__t$MapEntryOfC$MapEntryOfK$VToMapEntryOfK$V = dart.constFn(dart.fnType(__t$MapEntryOfK$V(), [__t$MapEntryOfC$MapEntryOfK$V()])))();
    var __t$CAndMapEntryOfK$VTovoid = () => (__t$CAndMapEntryOfK$VTovoid = dart.constFn(dart.fnType(dart.void, [C, __t$MapEntryOfK$V()])))();
    var __t$CAndMapEntryOfK$VTobool = () => (__t$CAndMapEntryOfK$VTobool = dart.constFn(dart.fnType(core.bool, [C, __t$MapEntryOfK$V()])))();
    var __t$CAndMapEntryOfK$VToMapEntryOfK$V = () => (__t$CAndMapEntryOfK$VToMapEntryOfK$V = dart.constFn(dart.fnType(__t$MapEntryOfK$V(), [C, __t$MapEntryOfK$V()])))();
    var __t$MapEntryOfK$V = () => (__t$MapEntryOfK$V = dart.constFn(core.MapEntry$(K, V)))();
    var __t$MapOfK$V = () => (__t$MapOfK$V = dart.constFn(core.Map$(K, V)))();
    var __t$KAndVTovoid = () => (__t$KAndVTovoid = dart.constFn(dart.fnType(dart.void, [K, V])))();
    var __t$IterableOfMapEntryOfK$V = () => (__t$IterableOfMapEntryOfK$V = dart.constFn(core.Iterable$(__t$MapEntryOfK$V())))();
    var __t$MapEntryOfK$VTobool = () => (__t$MapEntryOfK$VTobool = dart.constFn(dart.fnType(core.bool, [__t$MapEntryOfK$V()])))();
    var __t$MapEntryOfK$VToK = () => (__t$MapEntryOfK$VToK = dart.constFn(dart.fnType(K, [__t$MapEntryOfK$V()])))();
    var __t$VoidToMapEntryOfK$V = () => (__t$VoidToMapEntryOfK$V = dart.constFn(dart.fnType(__t$MapEntryOfK$V(), [])))();
    var __t$MapEntryOfK$VToMapEntryOfK$V = () => (__t$MapEntryOfK$VToMapEntryOfK$V = dart.constFn(dart.fnType(__t$MapEntryOfK$V(), [__t$MapEntryOfK$V()])))();
    var __t$KAndVToV = () => (__t$KAndVToV = dart.constFn(dart.fnType(V, [K, V])))();
    var __t$MapEntryOfK$VToV = () => (__t$MapEntryOfK$VToV = dart.constFn(dart.fnType(V, [__t$MapEntryOfK$V()])))();
    var __t$VoidToV = () => (__t$VoidToV = dart.constFn(dart.fnType(V, [])))();
    var __t$VToV = () => (__t$VToV = dart.constFn(dart.fnType(V, [V])))();
    var __t$VoidToNV = () => (__t$VoidToNV = dart.constFn(dart.nullable(__t$VoidToV())))();
    class CanonicalizedMap extends core.Object {
      static ['_#new#tearOff'](C, K, V, canonicalize, opts) {
        let isValidKey = opts && 'isValidKey' in opts ? opts.isValidKey : null;
        return new (canonicalized_map.CanonicalizedMap$(C, K, V)).new(canonicalize, {isValidKey: isValidKey});
      }
      static ['_#from#tearOff'](C, K, V, other, canonicalize, opts) {
        let isValidKey = opts && 'isValidKey' in opts ? opts.isValidKey : null;
        return new (canonicalized_map.CanonicalizedMap$(C, K, V)).from(other, canonicalize, {isValidKey: isValidKey});
      }
      _get(key) {
        let t0, t0$;
        if (!this[_isValidKey](key)) return null;
        let pair = this[_base][$_get]((t0 = K.as(key), this[_canonicalize](t0)));
        t0$ = pair;
        return t0$ == null ? null : t0$.value;
      }
      _set(key, value$) {
        let value = value$;
        let t0;
        K.as(key);
        V.as(value);
        if (!this[_isValidKey](key)) return value$;
        this[_base][$_set]((t0 = key, this[_canonicalize](t0)), new (__t$MapEntryOfK$V()).__(key, value));
        return value$;
      }
      addAll(other) {
        __t$MapOfK$V().as(other);
        other[$forEach](dart.fn((key, value) => {
          let t1, t0;
          t0 = key;
          t1 = value;
          this._set(t0, t1);
          return t1;
        }, __t$KAndVTovoid()));
      }
      addEntries(entries) {
        __t$IterableOfMapEntryOfK$V().as(entries);
        return this[_base][$addEntries](entries[$map](__t$MapEntryOfC$MapEntryOfK$V(), dart.fn(e => {
          let t0;
          return new (__t$MapEntryOfC$MapEntryOfK$V()).__((t0 = e.key, this[_canonicalize](t0)), new (__t$MapEntryOfK$V()).__(e.key, e.value));
        }, __t$MapEntryOfK$VToMapEntryOfC$MapEntryOfK$V())));
      }
      cast(K2, V2) {
        return this[_base][$cast](K2, V2);
      }
      clear() {
        this[_base][$clear]();
      }
      containsKey(key) {
        let t0;
        if (!this[_isValidKey](key)) return false;
        return this[_base][$containsKey]((t0 = K.as(key), this[_canonicalize](t0)));
      }
      containsValue(value) {
        return this[_base][$values][$any](dart.fn(pair => dart.equals(pair.value, value), __t$MapEntryOfK$VTobool()));
      }
      get entries() {
        return this[_base][$entries][$map](__t$MapEntryOfK$V(), dart.fn(e => new (__t$MapEntryOfK$V()).__(e.value.key, e.value.value), __t$MapEntryOfC$MapEntryOfK$VToMapEntryOfK$V()));
      }
      forEach(f) {
        this[_base][$forEach](dart.fn((key, pair) => f(pair.key, pair.value), __t$CAndMapEntryOfK$VTovoid()));
      }
      get isEmpty() {
        return this[_base][$isEmpty];
      }
      get isNotEmpty() {
        return this[_base][$isNotEmpty];
      }
      get keys() {
        return this[_base][$values][$map](K, dart.fn(pair => pair.key, __t$MapEntryOfK$VToK()));
      }
      get length() {
        return this[_base][$length];
      }
      map(K2, V2, transform) {
        return this[_base][$map](K2, V2, dart.fn((_, pair) => transform(pair.key, pair.value), dart.fnType(core.MapEntry$(K2, V2), [C, __t$MapEntryOfK$V()])));
      }
      putIfAbsent(key, ifAbsent) {
        let t0;
        K.as(key);
        __t$VoidToV().as(ifAbsent);
        return this[_base][$putIfAbsent]((t0 = key, this[_canonicalize](t0)), dart.fn(() => new (__t$MapEntryOfK$V()).__(key, ifAbsent()), __t$VoidToMapEntryOfK$V())).value;
      }
      remove(key) {
        let t0, t0$;
        if (!this[_isValidKey](key)) return null;
        let pair = this[_base][$remove]((t0 = K.as(key), this[_canonicalize](t0)));
        t0$ = pair;
        return t0$ == null ? null : t0$.value;
      }
      removeWhere(test) {
        return this[_base][$removeWhere](dart.fn((_, pair) => test(pair.key, pair.value), __t$CAndMapEntryOfK$VTobool()));
      }
      retype(K2, V2) {
        return this.cast(K2, V2);
      }
      update(key, update, opts) {
        let t0;
        K.as(key);
        __t$VToV().as(update);
        let ifAbsent = opts && 'ifAbsent' in opts ? opts.ifAbsent : null;
        __t$VoidToNV().as(ifAbsent);
        return this[_base][$update]((t0 = key, this[_canonicalize](t0)), dart.fn(pair => {
          let value = pair.value;
          let newValue = update(value);
          if (core.identical(newValue, value)) return pair;
          return new (__t$MapEntryOfK$V()).__(key, newValue);
        }, __t$MapEntryOfK$VToMapEntryOfK$V()), {ifAbsent: ifAbsent == null ? null : dart.fn(() => new (__t$MapEntryOfK$V()).__(key, ifAbsent()), __t$VoidToMapEntryOfK$V())}).value;
      }
      updateAll(update) {
        __t$KAndVToV().as(update);
        return this[_base][$updateAll](dart.fn((_, pair) => {
          let value = pair.value;
          let key = pair.key;
          let newValue = update(key, value);
          if (core.identical(value, newValue)) return pair;
          return new (__t$MapEntryOfK$V()).__(key, newValue);
        }, __t$CAndMapEntryOfK$VToMapEntryOfK$V()));
      }
      get values() {
        return this[_base][$values][$map](V, dart.fn(pair => pair.value, __t$MapEntryOfK$VToV()));
      }
      toString() {
        return collection.MapBase.mapToString(this);
      }
      [_isValidKey](key) {
        return K.is(key) && (this[_isValidKeyFn] == null || dart.nullCheck(this[_isValidKeyFn])(key));
      }
    }
    (CanonicalizedMap.new = function(canonicalize, opts) {
      let isValidKey = opts && 'isValidKey' in opts ? opts.isValidKey : null;
      this[_base] = new (__t$LinkedMapOfC$MapEntryOfK$V()).new();
      this[_canonicalize] = canonicalize;
      this[_isValidKeyFn] = isValidKey;
      ;
    }).prototype = CanonicalizedMap.prototype;
    (CanonicalizedMap.from = function(other, canonicalize, opts) {
      let isValidKey = opts && 'isValidKey' in opts ? opts.isValidKey : null;
      this[_base] = new (__t$LinkedMapOfC$MapEntryOfK$V()).new();
      this[_canonicalize] = canonicalize;
      this[_isValidKeyFn] = isValidKey;
      this.addAll(other);
    }).prototype = CanonicalizedMap.prototype;
    CanonicalizedMap.prototype[dart.isMap] = true;
    dart.addTypeTests(CanonicalizedMap);
    CanonicalizedMap.prototype[_is_CanonicalizedMap_default] = true;
    dart.addTypeCaches(CanonicalizedMap);
    CanonicalizedMap[dart.implements] = () => [core.Map$(K, V)];
    dart.setMethodSignature(CanonicalizedMap, () => ({
      __proto__: dart.getMethods(CanonicalizedMap.__proto__),
      _get: dart.fnType(dart.nullable(V), [dart.nullable(core.Object)]),
      [$_get]: dart.fnType(dart.nullable(V), [dart.nullable(core.Object)]),
      _set: dart.fnType(dart.void, [dart.nullable(core.Object), dart.nullable(core.Object)]),
      [$_set]: dart.fnType(dart.void, [dart.nullable(core.Object), dart.nullable(core.Object)]),
      addAll: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      [$addAll]: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      addEntries: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      [$addEntries]: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      cast: dart.gFnType((K2, V2) => [core.Map$(K2, V2), []], (K2, V2) => [dart.nullable(core.Object), dart.nullable(core.Object)]),
      [$cast]: dart.gFnType((K2, V2) => [core.Map$(K2, V2), []], (K2, V2) => [dart.nullable(core.Object), dart.nullable(core.Object)]),
      clear: dart.fnType(dart.void, []),
      [$clear]: dart.fnType(dart.void, []),
      containsKey: dart.fnType(core.bool, [dart.nullable(core.Object)]),
      [$containsKey]: dart.fnType(core.bool, [dart.nullable(core.Object)]),
      containsValue: dart.fnType(core.bool, [dart.nullable(core.Object)]),
      [$containsValue]: dart.fnType(core.bool, [dart.nullable(core.Object)]),
      forEach: dart.fnType(dart.void, [dart.fnType(dart.void, [K, V])]),
      [$forEach]: dart.fnType(dart.void, [dart.fnType(dart.void, [K, V])]),
      map: dart.gFnType((K2, V2) => [core.Map$(K2, V2), [dart.fnType(core.MapEntry$(K2, V2), [K, V])]], (K2, V2) => [dart.nullable(core.Object), dart.nullable(core.Object)]),
      [$map]: dart.gFnType((K2, V2) => [core.Map$(K2, V2), [dart.fnType(core.MapEntry$(K2, V2), [K, V])]], (K2, V2) => [dart.nullable(core.Object), dart.nullable(core.Object)]),
      putIfAbsent: dart.fnType(V, [dart.nullable(core.Object), dart.nullable(core.Object)]),
      [$putIfAbsent]: dart.fnType(V, [dart.nullable(core.Object), dart.nullable(core.Object)]),
      remove: dart.fnType(dart.nullable(V), [dart.nullable(core.Object)]),
      [$remove]: dart.fnType(dart.nullable(V), [dart.nullable(core.Object)]),
      removeWhere: dart.fnType(dart.void, [dart.fnType(core.bool, [K, V])]),
      [$removeWhere]: dart.fnType(dart.void, [dart.fnType(core.bool, [K, V])]),
      retype: dart.gFnType((K2, V2) => [core.Map$(K2, V2), []], (K2, V2) => [dart.nullable(core.Object), dart.nullable(core.Object)]),
      update: dart.fnType(V, [dart.nullable(core.Object), dart.nullable(core.Object)], {ifAbsent: dart.nullable(core.Object)}, {}),
      [$update]: dart.fnType(V, [dart.nullable(core.Object), dart.nullable(core.Object)], {ifAbsent: dart.nullable(core.Object)}, {}),
      updateAll: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      [$updateAll]: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      [_isValidKey]: dart.fnType(core.bool, [dart.nullable(core.Object)])
    }));
    dart.setGetterSignature(CanonicalizedMap, () => ({
      __proto__: dart.getGetters(CanonicalizedMap.__proto__),
      entries: core.Iterable$(core.MapEntry$(K, V)),
      [$entries]: core.Iterable$(core.MapEntry$(K, V)),
      isEmpty: core.bool,
      [$isEmpty]: core.bool,
      isNotEmpty: core.bool,
      [$isNotEmpty]: core.bool,
      keys: core.Iterable$(K),
      [$keys]: core.Iterable$(K),
      length: core.int,
      [$length]: core.int,
      values: core.Iterable$(V),
      [$values]: core.Iterable$(V)
    }));
    dart.setLibraryUri(CanonicalizedMap, I[0]);
    dart.setFieldSignature(CanonicalizedMap, () => ({
      __proto__: dart.getFields(CanonicalizedMap.__proto__),
      [_canonicalize]: dart.finalFieldType(dart.fnType(C, [K])),
      [_isValidKeyFn]: dart.finalFieldType(dart.nullable(dart.fnType(core.bool, [K]))),
      [_base]: dart.finalFieldType(core.Map$(C, core.MapEntry$(K, V)))
    }));
    dart.defineExtensionMethods(CanonicalizedMap, [
      '_get',
      '_set',
      'addAll',
      'addEntries',
      'cast',
      'clear',
      'containsKey',
      'containsValue',
      'forEach',
      'map',
      'putIfAbsent',
      'remove',
      'removeWhere',
      'update',
      'updateAll',
      'toString'
    ]);
    dart.defineExtensionAccessors(CanonicalizedMap, [
      'entries',
      'isEmpty',
      'isNotEmpty',
      'keys',
      'length',
      'values'
    ]);
    return CanonicalizedMap;
  });
  canonicalized_map.CanonicalizedMap = canonicalized_map.CanonicalizedMap$();
  dart.addTypeTests(canonicalized_map.CanonicalizedMap, _is_CanonicalizedMap_default);
  dart.trackLibraries("packages/collection/src/canonicalized_map.dart", {
    "package:collection/src/canonicalized_map.dart": canonicalized_map
  }, {
  }, '{"version":3,"sourceRoot":"","sources":["canonicalized_map.dart"],"names":[],"mappings":";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;WAiDyB;;AACrB,aAAK,kBAAY,GAAG,GAAG,MAAO;AAC1B,mBAAO,AAAK,yBAAmB,KAAJ,GAAG,GAAjB,AAAa;AAC9B,cAAO,IAAI;6BAAJ,OAAM;MACf;WAGoB;YAAO;;;;AACzB,aAAK,kBAAY,GAAG,GAAG;AACyB,QAAhD,AAAK,yBAAe,GAAG,EAAjB,AAAa,0BAAS,6BAAS,GAAG,EAAE,KAAK;;MACjD;aAGsB;;AAC4B,QAAhD,AAAM,KAAD,WAAS,SAAC,KAAK;;AAAU,eAAK,GAAG;eAAI,KAAK;UAAb;;;MACpC;iBAGyC;;AAAY,cAAA,AAAM,0BAAW,AACjE,OADwE,wCACpE,QAAC;;AAAM,gEAAuB,AAAE,CAAD,MAAf,AAAa,0BAAS,6BAAS,AAAE,CAAD,MAAM,AAAE,CAAD;;MAAU;;AAG5C,cAAA,AAAM;MAAc;;AAInC,QAAb,AAAM;MACR;kBAGyB;;AACvB,aAAK,kBAAY,GAAG,GAAG,MAAO;AAC9B,cAAO,AAAM,iCAA8B,KAAJ,GAAG,GAAjB,AAAa;MACxC;oBAG2B;AACvB,cAAA,AAAM,AAAO,4BAAI,QAAC,QAAoB,YAAX,AAAK,IAAD,QAAU,KAAK;MAAC;;AAI/C,cAAA,AAAM,AAAQ,kDAAI,QAAC,KAAM,6BAAS,AAAE,AAAM,CAAP,YAAY,AAAE,AAAM,CAAP;MAAc;cAGjC;AACsB,QAArD,AAAM,sBAAQ,SAAC,KAAK,SAAS,AAAC,CAAA,CAAC,AAAK,IAAD,MAAM,AAAK,IAAD;MAC/C;;AAGoB,cAAA,AAAM;MAAO;;AAGV,cAAA,AAAM;MAAU;;AAGf,cAAA,AAAM,AAAO,+BAAI,QAAC,QAAS,AAAK,IAAD;MAAK;;AAG1C,cAAA,AAAM;MAAM;kBAG0B;AACpD,cAAA,AAAM,2BAAI,SAAC,GAAG,SAAS,AAAS,SAAA,CAAC,AAAK,IAAD,MAAM,AAAK,IAAD;MAAQ;kBAG3C,KAAkB;;;;AAChC,cAAO,AACF,AACA,iCAD0B,GAAG,EAAjB,AAAa,0BAAO,cAAM,6BAAS,GAAG,EAAE,AAAQ,QAAA;MAEnE;aAGkB;;AAChB,aAAK,kBAAY,GAAG,GAAG,MAAO;AAC1B,mBAAO,AAAM,2BAAyB,KAAJ,GAAG,GAAjB,AAAa;AACrC,cAAO,IAAI;6BAAJ,OAAM;MACf;kBAG+C;AAC3C,cAAA,AAAM,2BAAY,SAAC,GAAG,SAAS,AAAI,IAAA,CAAC,AAAK,IAAD,MAAM,AAAK,IAAD;MAAQ;;AAG9B;MAAc;aAGnC,KAAmB;;;;YAAuB;;AACjD,cAAA,AAAM,AAO6D,4BAPxC,GAAG,EAAjB,AAAa,0BAAO,QAAC;AAC5B,sBAAQ,AAAK,IAAD;AACZ,yBAAW,AAAM,MAAA,CAAC,KAAK;AAC3B,cAAI,eAAU,QAAQ,EAAE,KAAK,GAAG,MAAO,KAAI;AAC3C,gBAAO,8BAAS,GAAG,EAAE,QAAQ;2DAGvB,AAAS,QAAD,WAAW,OAAO,cAAM,6BAAS,GAAG,EAAE,AAAQ,QAAA;MAAU;gBAGlC;;AACtC,cAAA,AAAM,yBAAU,SAAC,GAAG;AACd,sBAAQ,AAAK,IAAD;AACZ,oBAAM,AAAK,IAAD;AACV,yBAAW,AAAM,MAAA,CAAC,GAAG,EAAE,KAAK;AAChC,cAAI,eAAU,KAAK,EAAE,QAAQ,GAAG,MAAO,KAAI;AAC3C,gBAAO,8BAAS,GAAG,EAAE,QAAQ;;MAC7B;;AAGoB,cAAA,AAAM,AAAO,+BAAI,QAAC,QAAS,AAAK,IAAD;MAAO;;AAG3C,cAAQ,gCAAY;MAAK;oBAErB;AACrB,cAAK,AAAM,MAAV,GAAG,MAAW,AAAc,+BAAwB,AAAC,eAAd,qBAAe,GAAG;MAAE;;qCAvI7B;UACR;MAXrB,cAA2B;MAYb,sBAAE,YAAY;MACd,sBAAE,UAAU;;;sCAWA,OAAyB;UAC9B;MAzBrB,cAA2B;MA0Bb,sBAAE,YAAY;MACd,sBAAE,UAAU;AACjB,MAAb,YAAO,KAAK;IACd","file":"../../../../../../../../../../../packages/collection/src/canonicalized_map.dart.lib.js"}');
  // Exports:
  return {
    src__canonicalized_map: canonicalized_map
  };
}));

//# sourceMappingURL=canonicalized_map.dart.lib.js.map

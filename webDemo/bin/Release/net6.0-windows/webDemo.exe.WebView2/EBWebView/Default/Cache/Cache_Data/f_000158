define(['dart_sdk', 'packages/async/src/delegate/stream_sink.dart'], (function load__packages__async__src__stream_sink_transformer__typed_dart(dart_sdk, packages__async__src__delegate__stream_sink$46dart) {
  'use strict';
  const core = dart_sdk.core;
  const async = dart_sdk.async;
  const dart = dart_sdk.dart;
  const dartx = dart_sdk.dartx;
  const stream_sink = packages__async__src__delegate__stream_sink$46dart.src__delegate__stream_sink;
  var typed = Object.create(dart.library);
  var stream_transformer_wrapper = Object.create(dart.library);
  var handler_transformer = Object.create(dart.library);
  var stream_sink_transformer = Object.create(dart.library);
  dart._checkModuleNullSafetyMode(true);
  dart._checkModuleRuntimeTypes(false);
  var T$ = {
    dynamicToNull: () => (T$.dynamicToNull = dart.constFn(dart.fnType(core.Null, [dart.dynamic])))(),
    VoidTovoid: () => (T$.VoidTovoid = dart.constFn(dart.fnType(dart.void, [])))(),
    EventSinkTovoid: () => (T$.EventSinkTovoid = dart.constFn(dart.fnType(dart.void, [async.EventSink])))()
  };
  const CT = Object.create({
    _: () => (C, CT)
  });
  dart.defineLazy(CT, {
    get C0() {
      return C[0] = dart.fn(handler_transformer._closeSink, T$.EventSinkTovoid());
    }
  }, false);
  var C = [void 0];
  var I = [
    "package:async/src/stream_sink_transformer/typed.dart",
    "package:async/src/stream_sink_transformer/stream_transformer_wrapper.dart",
    "package:async/src/stream_sink_transformer/handler_transformer.dart",
    "package:async/src/stream_sink_transformer.dart"
  ];
  var _inner$ = dart.privateName(typed, "_inner");
  const _is_TypeSafeStreamSinkTransformer_default = Symbol('_is_TypeSafeStreamSinkTransformer_default');
  typed.TypeSafeStreamSinkTransformer$ = dart.generic((S, T) => {
    var __t$StreamControllerOfS = () => (__t$StreamControllerOfS = dart.constFn(async.StreamController$(S)))();
    var __t$StreamSinkOfT = () => (__t$StreamSinkOfT = dart.constFn(async.StreamSink$(T)))();
    class TypeSafeStreamSinkTransformer extends core.Object {
      static ['_#new#tearOff'](S, T, _inner) {
        return new (typed.TypeSafeStreamSinkTransformer$(S, T)).new(_inner);
      }
      bind(sink) {
        let t0;
        __t$StreamSinkOfT().as(sink);
        t0 = __t$StreamControllerOfS().new({sync: true});
        return (() => {
          t0.stream.cast(dart.dynamic).pipe(this[_inner$].bind(sink));
          return t0;
        })();
      }
    }
    (TypeSafeStreamSinkTransformer.new = function(_inner) {
      this[_inner$] = _inner;
      ;
    }).prototype = TypeSafeStreamSinkTransformer.prototype;
    dart.addTypeTests(TypeSafeStreamSinkTransformer);
    TypeSafeStreamSinkTransformer.prototype[_is_TypeSafeStreamSinkTransformer_default] = true;
    dart.addTypeCaches(TypeSafeStreamSinkTransformer);
    TypeSafeStreamSinkTransformer[dart.implements] = () => [stream_sink_transformer.StreamSinkTransformer$(S, T)];
    dart.setMethodSignature(TypeSafeStreamSinkTransformer, () => ({
      __proto__: dart.getMethods(TypeSafeStreamSinkTransformer.__proto__),
      bind: dart.fnType(async.StreamSink$(S), [dart.nullable(core.Object)])
    }));
    dart.setLibraryUri(TypeSafeStreamSinkTransformer, I[0]);
    dart.setFieldSignature(TypeSafeStreamSinkTransformer, () => ({
      __proto__: dart.getFields(TypeSafeStreamSinkTransformer.__proto__),
      [_inner$]: dart.finalFieldType(stream_sink_transformer.StreamSinkTransformer)
    }));
    return TypeSafeStreamSinkTransformer;
  });
  typed.TypeSafeStreamSinkTransformer = typed.TypeSafeStreamSinkTransformer$();
  dart.addTypeTests(typed.TypeSafeStreamSinkTransformer, _is_TypeSafeStreamSinkTransformer_default);
  var _transformer$ = dart.privateName(stream_transformer_wrapper, "StreamTransformerWrapper._transformer");
  var _transformer = dart.privateName(stream_transformer_wrapper, "_transformer");
  const _is_StreamTransformerWrapper_default = Symbol('_is_StreamTransformerWrapper_default');
  stream_transformer_wrapper.StreamTransformerWrapper$ = dart.generic((S, T) => {
    var __t$_StreamTransformerWrapperSinkOfS$T = () => (__t$_StreamTransformerWrapperSinkOfS$T = dart.constFn(stream_transformer_wrapper._StreamTransformerWrapperSink$(S, T)))();
    var __t$StreamSinkOfT = () => (__t$StreamSinkOfT = dart.constFn(async.StreamSink$(T)))();
    class StreamTransformerWrapper extends core.Object {
      get [_transformer]() {
        return this[_transformer$];
      }
      set [_transformer](value) {
        super[_transformer] = value;
      }
      static ['_#new#tearOff'](S, T, _transformer) {
        return new (stream_transformer_wrapper.StreamTransformerWrapper$(S, T)).new(_transformer);
      }
      bind(sink) {
        __t$StreamSinkOfT().as(sink);
        return new (__t$_StreamTransformerWrapperSinkOfS$T()).new(this[_transformer], sink);
      }
    }
    (StreamTransformerWrapper.new = function(_transformer) {
      this[_transformer$] = _transformer;
      ;
    }).prototype = StreamTransformerWrapper.prototype;
    dart.addTypeTests(StreamTransformerWrapper);
    StreamTransformerWrapper.prototype[_is_StreamTransformerWrapper_default] = true;
    dart.addTypeCaches(StreamTransformerWrapper);
    StreamTransformerWrapper[dart.implements] = () => [stream_sink_transformer.StreamSinkTransformer$(S, T)];
    dart.setMethodSignature(StreamTransformerWrapper, () => ({
      __proto__: dart.getMethods(StreamTransformerWrapper.__proto__),
      bind: dart.fnType(async.StreamSink$(S), [dart.nullable(core.Object)])
    }));
    dart.setLibraryUri(StreamTransformerWrapper, I[1]);
    dart.setFieldSignature(StreamTransformerWrapper, () => ({
      __proto__: dart.getFields(StreamTransformerWrapper.__proto__),
      [_transformer]: dart.finalFieldType(async.StreamTransformer$(S, T))
    }));
    return StreamTransformerWrapper;
  });
  stream_transformer_wrapper.StreamTransformerWrapper = stream_transformer_wrapper.StreamTransformerWrapper$();
  dart.addTypeTests(stream_transformer_wrapper.StreamTransformerWrapper, _is_StreamTransformerWrapper_default);
  var _controller = dart.privateName(stream_transformer_wrapper, "_controller");
  var _inner$0 = dart.privateName(stream_transformer_wrapper, "_inner");
  const _is__StreamTransformerWrapperSink_default = Symbol('_is__StreamTransformerWrapperSink_default');
  stream_transformer_wrapper._StreamTransformerWrapperSink$ = dart.generic((S, T) => {
    var __t$StreamControllerOfS = () => (__t$StreamControllerOfS = dart.constFn(async.StreamController$(S)))();
    var __t$StreamOfS = () => (__t$StreamOfS = dart.constFn(async.Stream$(S)))();
    var __t$TTovoid = () => (__t$TTovoid = dart.constFn(dart.fnType(dart.void, [T])))();
    class _StreamTransformerWrapperSink extends core.Object {
      get done() {
        return this[_inner$0].done;
      }
      static ['_#new#tearOff'](S, T, transformer, _inner) {
        return new (stream_transformer_wrapper._StreamTransformerWrapperSink$(S, T)).new(transformer, _inner);
      }
      add(event) {
        S.as(event);
        this[_controller].add(event);
      }
      addError(error, stackTrace = null) {
        this[_controller].addError(error, stackTrace);
      }
      addStream(stream) {
        __t$StreamOfS().as(stream);
        return this[_controller].addStream(stream);
      }
      close() {
        this[_controller].close();
        return this[_inner$0].done;
      }
    }
    (_StreamTransformerWrapperSink.new = function(transformer, _inner) {
      this[_controller] = __t$StreamControllerOfS().new({sync: true});
      this[_inner$0] = _inner;
      this[_controller].stream.transform(T, transformer).listen(__t$TTovoid().as(dart.bind(this[_inner$0], 'add')), {onError: dart.bind(this[_inner$0], 'addError'), onDone: dart.fn(() => {
          this[_inner$0].close().catchError(dart.fn(_ => {
          }, T$.dynamicToNull()));
        }, T$.VoidTovoid())});
    }).prototype = _StreamTransformerWrapperSink.prototype;
    dart.addTypeTests(_StreamTransformerWrapperSink);
    _StreamTransformerWrapperSink.prototype[_is__StreamTransformerWrapperSink_default] = true;
    dart.addTypeCaches(_StreamTransformerWrapperSink);
    _StreamTransformerWrapperSink[dart.implements] = () => [async.StreamSink$(S)];
    dart.setMethodSignature(_StreamTransformerWrapperSink, () => ({
      __proto__: dart.getMethods(_StreamTransformerWrapperSink.__proto__),
      add: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      addError: dart.fnType(dart.void, [core.Object], [dart.nullable(core.StackTrace)]),
      addStream: dart.fnType(async.Future, [dart.nullable(core.Object)]),
      close: dart.fnType(async.Future, [])
    }));
    dart.setGetterSignature(_StreamTransformerWrapperSink, () => ({
      __proto__: dart.getGetters(_StreamTransformerWrapperSink.__proto__),
      done: async.Future
    }));
    dart.setLibraryUri(_StreamTransformerWrapperSink, I[1]);
    dart.setFieldSignature(_StreamTransformerWrapperSink, () => ({
      __proto__: dart.getFields(_StreamTransformerWrapperSink.__proto__),
      [_controller]: dart.finalFieldType(async.StreamController$(S)),
      [_inner$0]: dart.finalFieldType(async.StreamSink$(T))
    }));
    return _StreamTransformerWrapperSink;
  });
  stream_transformer_wrapper._StreamTransformerWrapperSink = stream_transformer_wrapper._StreamTransformerWrapperSink$();
  dart.addTypeTests(stream_transformer_wrapper._StreamTransformerWrapperSink, _is__StreamTransformerWrapperSink_default);
  var _handleData$ = dart.privateName(handler_transformer, "_handleData");
  var _handleError$ = dart.privateName(handler_transformer, "_handleError");
  var _handleDone$ = dart.privateName(handler_transformer, "_handleDone");
  const _is_HandlerTransformer_default = Symbol('_is_HandlerTransformer_default');
  handler_transformer.HandlerTransformer$ = dart.generic((S, T) => {
    var __t$_HandlerSinkOfS$T = () => (__t$_HandlerSinkOfS$T = dart.constFn(handler_transformer._HandlerSink$(S, T)))();
    var __t$StreamSinkOfT = () => (__t$StreamSinkOfT = dart.constFn(async.StreamSink$(T)))();
    class HandlerTransformer extends core.Object {
      static ['_#new#tearOff'](S, T, _handleData, _handleError, _handleDone) {
        return new (handler_transformer.HandlerTransformer$(S, T)).new(_handleData, _handleError, _handleDone);
      }
      bind(sink) {
        __t$StreamSinkOfT().as(sink);
        return new (__t$_HandlerSinkOfS$T()).new(this, sink);
      }
    }
    (HandlerTransformer.new = function(_handleData, _handleError, _handleDone) {
      this[_handleData$] = _handleData;
      this[_handleError$] = _handleError;
      this[_handleDone$] = _handleDone;
      ;
    }).prototype = HandlerTransformer.prototype;
    dart.addTypeTests(HandlerTransformer);
    HandlerTransformer.prototype[_is_HandlerTransformer_default] = true;
    dart.addTypeCaches(HandlerTransformer);
    HandlerTransformer[dart.implements] = () => [stream_sink_transformer.StreamSinkTransformer$(S, T)];
    dart.setMethodSignature(HandlerTransformer, () => ({
      __proto__: dart.getMethods(HandlerTransformer.__proto__),
      bind: dart.fnType(async.StreamSink$(S), [dart.nullable(core.Object)])
    }));
    dart.setLibraryUri(HandlerTransformer, I[2]);
    dart.setFieldSignature(HandlerTransformer, () => ({
      __proto__: dart.getFields(HandlerTransformer.__proto__),
      [_handleData$]: dart.finalFieldType(dart.nullable(dart.fnType(dart.void, [S, async.EventSink$(T)]))),
      [_handleError$]: dart.finalFieldType(dart.nullable(dart.fnType(dart.void, [core.Object, core.StackTrace, async.EventSink$(T)]))),
      [_handleDone$]: dart.finalFieldType(dart.nullable(dart.fnType(dart.void, [async.EventSink$(T)])))
    }));
    return HandlerTransformer;
  });
  handler_transformer.HandlerTransformer = handler_transformer.HandlerTransformer$();
  dart.addTypeTests(handler_transformer.HandlerTransformer, _is_HandlerTransformer_default);
  var _transformer$0 = dart.privateName(handler_transformer, "_transformer");
  var _inner = dart.privateName(handler_transformer, "_inner");
  var _safeCloseInner = dart.privateName(handler_transformer, "_safeCloseInner");
  const _is__HandlerSink_default = Symbol('_is__HandlerSink_default');
  handler_transformer._HandlerSink$ = dart.generic((S, T) => {
    var __t$SAndEventSinkOfTTovoid = () => (__t$SAndEventSinkOfTTovoid = dart.constFn(dart.fnType(dart.void, [S, __t$EventSinkOfT()])))();
    var __t$SAndEventSinkOfTToNvoid = () => (__t$SAndEventSinkOfTToNvoid = dart.constFn(dart.nullable(__t$SAndEventSinkOfTTovoid())))();
    var __t$StreamOfS = () => (__t$StreamOfS = dart.constFn(async.Stream$(S)))();
    var __t$_StreamHandlerTransformerOfS$T = () => (__t$_StreamHandlerTransformerOfS$T = dart.constFn(async._StreamHandlerTransformer$(S, T)))();
    var __t$_SafeCloseSinkOfT = () => (__t$_SafeCloseSinkOfT = dart.constFn(handler_transformer._SafeCloseSink$(T)))();
    var __t$EventSinkOfT = () => (__t$EventSinkOfT = dart.constFn(async.EventSink$(T)))();
    var __t$ObjectAndStackTraceAndEventSinkOfTTovoid = () => (__t$ObjectAndStackTraceAndEventSinkOfTTovoid = dart.constFn(dart.fnType(dart.void, [core.Object, core.StackTrace, __t$EventSinkOfT()])))();
    var __t$ObjectAndStackTraceAndEventSinkOfTToNvoid = () => (__t$ObjectAndStackTraceAndEventSinkOfTToNvoid = dart.constFn(dart.nullable(__t$ObjectAndStackTraceAndEventSinkOfTTovoid())))();
    var __t$EventSinkOfTTovoid = () => (__t$EventSinkOfTTovoid = dart.constFn(dart.fnType(dart.void, [__t$EventSinkOfT()])))();
    var __t$EventSinkOfTToNvoid = () => (__t$EventSinkOfTToNvoid = dart.constFn(dart.nullable(__t$EventSinkOfTTovoid())))();
    class _HandlerSink extends core.Object {
      get done() {
        return this[_inner].done;
      }
      static ['_#new#tearOff'](S, T, _transformer, inner) {
        return new (handler_transformer._HandlerSink$(S, T)).new(_transformer, inner);
      }
      add(event) {
        S.as(event);
        let handleData = __t$SAndEventSinkOfTToNvoid().as(this[_transformer$0][_handleData$]);
        if (handleData == null) {
          this[_inner].add(T.as(event));
        } else {
          handleData(event, this[_safeCloseInner]);
        }
      }
      addError(error, stackTrace = null) {
        let t0;
        let handleError = __t$ObjectAndStackTraceAndEventSinkOfTToNvoid().as(this[_transformer$0][_handleError$]);
        if (handleError == null) {
          this[_inner].addError(error, stackTrace);
        } else {
          handleError(error, (t0 = stackTrace, t0 == null ? async.AsyncError.defaultStackTrace(error) : t0), this[_safeCloseInner]);
        }
      }
      addStream(stream) {
        __t$StreamOfS().as(stream);
        return this[_inner].addStream(stream.transform(T, new (__t$_StreamHandlerTransformerOfS$T()).new({handleData: __t$SAndEventSinkOfTToNvoid().as(this[_transformer$0][_handleData$]), handleError: __t$ObjectAndStackTraceAndEventSinkOfTToNvoid().as(this[_transformer$0][_handleError$]), handleDone: C[0] || CT.C0})));
      }
      close() {
        let handleDone = __t$EventSinkOfTToNvoid().as(this[_transformer$0][_handleDone$]);
        if (handleDone == null) return this[_inner].close();
        handleDone(this[_safeCloseInner]);
        return this[_inner].done;
      }
    }
    (_HandlerSink.new = function(_transformer, inner) {
      this[_transformer$0] = _transformer;
      this[_inner] = inner;
      this[_safeCloseInner] = new (__t$_SafeCloseSinkOfT()).new(inner);
      ;
    }).prototype = _HandlerSink.prototype;
    dart.addTypeTests(_HandlerSink);
    _HandlerSink.prototype[_is__HandlerSink_default] = true;
    dart.addTypeCaches(_HandlerSink);
    _HandlerSink[dart.implements] = () => [async.StreamSink$(S)];
    dart.setMethodSignature(_HandlerSink, () => ({
      __proto__: dart.getMethods(_HandlerSink.__proto__),
      add: dart.fnType(dart.void, [dart.nullable(core.Object)]),
      addError: dart.fnType(dart.void, [core.Object], [dart.nullable(core.StackTrace)]),
      addStream: dart.fnType(async.Future, [dart.nullable(core.Object)]),
      close: dart.fnType(async.Future, [])
    }));
    dart.setGetterSignature(_HandlerSink, () => ({
      __proto__: dart.getGetters(_HandlerSink.__proto__),
      done: async.Future
    }));
    dart.setLibraryUri(_HandlerSink, I[2]);
    dart.setFieldSignature(_HandlerSink, () => ({
      __proto__: dart.getFields(_HandlerSink.__proto__),
      [_transformer$0]: dart.finalFieldType(handler_transformer.HandlerTransformer$(S, T)),
      [_inner]: dart.finalFieldType(async.StreamSink$(T)),
      [_safeCloseInner]: dart.finalFieldType(async.StreamSink$(T))
    }));
    return _HandlerSink;
  });
  handler_transformer._HandlerSink = handler_transformer._HandlerSink$();
  dart.addTypeTests(handler_transformer._HandlerSink, _is__HandlerSink_default);
  const _is__SafeCloseSink_default = Symbol('_is__SafeCloseSink_default');
  handler_transformer._SafeCloseSink$ = dart.generic(T => {
    class _SafeCloseSink extends stream_sink.DelegatingStreamSink$(T) {
      static ['_#new#tearOff'](T, inner) {
        return new (handler_transformer._SafeCloseSink$(T)).new(inner);
      }
      close() {
        return super.close().catchError(dart.fn(_ => {
        }, T$.dynamicToNull()));
      }
    }
    (_SafeCloseSink.new = function(inner) {
      _SafeCloseSink.__proto__.new.call(this, inner);
      ;
    }).prototype = _SafeCloseSink.prototype;
    dart.addTypeTests(_SafeCloseSink);
    _SafeCloseSink.prototype[_is__SafeCloseSink_default] = true;
    dart.addTypeCaches(_SafeCloseSink);
    dart.setLibraryUri(_SafeCloseSink, I[2]);
    return _SafeCloseSink;
  });
  handler_transformer._SafeCloseSink = handler_transformer._SafeCloseSink$();
  dart.addTypeTests(handler_transformer._SafeCloseSink, _is__SafeCloseSink_default);
  handler_transformer._closeSink = function _closeSink(sink) {
    sink.close();
  };
  const _is_StreamSinkTransformer_default = Symbol('_is_StreamSinkTransformer_default');
  stream_sink_transformer.StreamSinkTransformer$ = dart.generic((S, T) => {
    class StreamSinkTransformer extends core.Object {
      static ['_#fromStreamTransformer#tearOff'](S, T, transformer) {
        return new (stream_transformer_wrapper.StreamTransformerWrapper$(S, T)).new(transformer);
      }
      static fromHandlers(opts) {
        let handleData = opts && 'handleData' in opts ? opts.handleData : null;
        let handleError = opts && 'handleError' in opts ? opts.handleError : null;
        let handleDone = opts && 'handleDone' in opts ? opts.handleDone : null;
        return new (handler_transformer.HandlerTransformer$(S, T)).new(handleData, handleError, handleDone);
      }
      static ['_#fromHandlers#tearOff'](S, T, opts) {
        let handleData = opts && 'handleData' in opts ? opts.handleData : null;
        let handleError = opts && 'handleError' in opts ? opts.handleError : null;
        let handleDone = opts && 'handleDone' in opts ? opts.handleDone : null;
        return stream_sink_transformer.StreamSinkTransformer$(S, T).fromHandlers({handleData: handleData, handleError: handleError, handleDone: handleDone});
      }
      static typed(S, T, transformer) {
        return stream_sink_transformer.StreamSinkTransformer$(S, T).is(transformer) ? transformer : new (typed.TypeSafeStreamSinkTransformer$(S, T)).new(transformer);
      }
    }
    (StreamSinkTransformer[dart.mixinNew] = function() {
    }).prototype = StreamSinkTransformer.prototype;
    dart.addTypeTests(StreamSinkTransformer);
    StreamSinkTransformer.prototype[_is_StreamSinkTransformer_default] = true;
    dart.addTypeCaches(StreamSinkTransformer);
    dart.setStaticMethodSignature(StreamSinkTransformer, () => ['fromStreamTransformer', 'fromHandlers', 'typed']);
    dart.setLibraryUri(StreamSinkTransformer, I[3]);
    dart.setStaticFieldSignature(StreamSinkTransformer, () => ['_redirecting#']);
    return StreamSinkTransformer;
  });
  stream_sink_transformer.StreamSinkTransformer = stream_sink_transformer.StreamSinkTransformer$();
  dart.addTypeTests(stream_sink_transformer.StreamSinkTransformer, _is_StreamSinkTransformer_default);
  dart.trackLibraries("packages/async/src/stream_sink_transformer/typed.dart", {
    "package:async/src/stream_sink_transformer/typed.dart": typed,
    "package:async/src/stream_sink_transformer/stream_transformer_wrapper.dart": stream_transformer_wrapper,
    "package:async/src/stream_sink_transformer/handler_transformer.dart": handler_transformer,
    "package:async/src/stream_sink_transformer.dart": stream_sink_transformer
  }, {
  }, '{"version":3,"sourceRoot":"","sources":["typed.dart","stream_transformer_wrapper.dart","handler_transformer.dart","../stream_sink_transformer.dart"],"names":[],"mappings":";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;WAiBmC;;;AAAS,kDAAuB;cAAvB;AACf,UAAvB,AAAO,kCAAqB,AAAO,mBAAK,IAAI;;;MAAE;;;MAJf;;IAAO;;;;;;;;;;;;;;;;;;;;;;;;;MCHZ;;;;;;;;;WAKG;;AAC7B,kEAAoC,oBAAc,IAAI;MAAC;;;MAJvB;;IAAa;;;;;;;;;;;;;;;;;;;;;;;;;;;AAmB9B,cAAA,AAAO;MAAI;;;;UAenB;;AACa,QAAtB,AAAY,sBAAI,KAAK;MACvB;eAGc,OAAoB;AACO,QAAvC,AAAY,2BAAS,KAAK,EAAE,UAAU;MACxC;gBAG2B;;AAAW,cAAA,AAAY,6BAAU,MAAM;MAAC;;AAI9C,QAAnB,AAAY;AACZ,cAAO,AAAO;MAChB;;kDA5B4B,aAAkB;MATxC,oBAAc,qCAA0B;MASA;AAQ1C,MAPF,AAAY,AACP,AACA,sCADU,WAAW,0BACP,UAAP,mCAA4B,UAAP,qCAAyB;AAIvB,UAAjC,AAAO,AAAQ,kCAAW,QAAC;;;IAE/B;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;WCZiC;;AAAS,iDAAmB,MAAM,IAAI;MAAC;;uCAHhD,aAAkB,cAAmB;MAArC;MAAkB;MAAmB;;IAAY;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;AAmBtD,cAAA,AAAO;MAAI;;;;UAOnB;;AACL,0DAAa,AAAa;AAC9B,YAAI,AAAW,UAAD;AACU,UAAtB,AAAO,iBAAU,KAAN,KAAK;;AAEkB,UAAlC,AAAU,UAAA,CAAC,KAAK,EAAE;;MAEtB;eAGc,OAAoB;;AAC5B,6EAAc,AAAa;AAC/B,YAAI,AAAY,WAAD;AACqB,UAAlC,AAAO,sBAAS,KAAK,EAAE,UAAU;;AAGb,UADpB,AAAW,WAAA,CAAC,KAAK,GAAa,KAAX,UAAU,EAAV,aAAyB,mCAAkB,KAAK,SAC/D;;MAER;gBAG2B;;AACzB,cAAO,AAAO,wBAAU,AAAO,MAAD,cAC1B,6FACgB,AAAa,qGACZ,AAAa;MAEpC;;AAIM,sDAAa,AAAa;AAC9B,YAAI,AAAW,UAAD,UAAU,MAAO,AAAO;AAEX,QAA3B,AAAU,UAAA,CAAC;AACX,cAAO,AAAO;MAChB;;iCAzCkB,cAA4B;MAA5B;MACL,eAAE,KAAK;MACE,wBAAE,kCAAkB,KAAK;;IAAC;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;AAmD9B,cAAM,AAAQ,0BAAW,QAAC;;MAAM;;mCAHrB;AAAS,8CAAM,KAAK;;IAAC;;;;;;;;;uDAO1B;AACZ,IAAZ,AAAK,IAAD;EACN;;;;;;;;YCzEuC;YACgB;YACpB;AAC/B,cAAO,yDAAyB,UAAU,EAAE,WAAW,EAAE,UAAU;MACrE;;;;;;;yBAkB8B;AAC1B,cAAY,yDAAZ,WAAW,IACL,WAAW,GACX,qDAA8B,WAAW;MAAC","file":"../../../../../../../../../../../../packages/async/src/stream_sink_transformer/typed.dart.lib.js"}');
  // Exports:
  return {
    src__stream_sink_transformer__typed: typed,
    src__stream_sink_transformer__stream_transformer_wrapper: stream_transformer_wrapper,
    src__stream_sink_transformer__handler_transformer: handler_transformer,
    src__stream_sink_transformer: stream_sink_transformer
  };
}));

//# sourceMappingURL=typed.dart.lib.js.map

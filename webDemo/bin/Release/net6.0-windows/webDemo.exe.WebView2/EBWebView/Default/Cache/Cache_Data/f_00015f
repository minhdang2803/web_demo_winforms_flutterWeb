define(['dart_sdk', 'packages/material_color_utilities/utils/math_utils.dart', 'packages/material_color_utilities/hct/viewing_conditions.dart', 'packages/material_color_utilities/utils/color_utils.dart', 'packages/material_color_utilities/hct/cam16.dart'], (function load__packages__material_color_utilities__hct__cam_solver_dart(dart_sdk, packages__material_color_utilities__utils__math_utils$46dart, packages__material_color_utilities__hct__viewing_conditions$46dart, packages__material_color_utilities__utils__color_utils$46dart, packages__material_color_utilities__hct__cam16$46dart) {
  'use strict';
  const core = dart_sdk.core;
  const math = dart_sdk.math;
  const _interceptors = dart_sdk._interceptors;
  const dart = dart_sdk.dart;
  const dartx = dart_sdk.dartx;
  const math_utils = packages__material_color_utilities__utils__math_utils$46dart.utils__math_utils;
  const viewing_conditions = packages__material_color_utilities__hct__viewing_conditions$46dart.hct__viewing_conditions;
  const color_utils = packages__material_color_utilities__utils__color_utils$46dart.utils__color_utils;
  const cam16 = packages__material_color_utilities__hct__cam16$46dart.hct__cam16;
  var cam_solver = Object.create(dart.library);
  var $modulo = dartx['%'];
  var $toDouble = dartx.toDouble;
  var $abs = dartx.abs;
  var $_get = dartx._get;
  var $where = dartx.where;
  var $toList = dartx.toList;
  var $first = dartx.first;
  var $skip = dartx.skip;
  var $floor = dartx.floor;
  var $ceil = dartx.ceil;
  dart._checkModuleNullSafetyMode(true);
  dart._checkModuleRuntimeTypes(false);
  var T = {
    JSArrayOfdouble: () => (T.JSArrayOfdouble = dart.constFn(_interceptors.JSArray$(core.double)))(),
    ListOfdouble: () => (T.ListOfdouble = dart.constFn(core.List$(core.double)))(),
    JSArrayOfListOfdouble: () => (T.JSArrayOfListOfdouble = dart.constFn(_interceptors.JSArray$(T.ListOfdouble())))(),
    ListOfdoubleTobool: () => (T.ListOfdoubleTobool = dart.constFn(dart.fnType(core.bool, [T.ListOfdouble()])))()
  };
  const CT = Object.create({
    _: () => (C, CT)
  });
  var I = ["package:material_color_utilities/hct/cam_solver.dart"];
  cam_solver.CamSolver = class CamSolver extends core.Object {
    static _sanitizeRadians(angle) {
      return (angle + 3.141592653589793 * 8)[$modulo](3.141592653589793 * 2);
    }
    static _trueDelinearized(rgbComponent) {
      let normalized = rgbComponent / 100.0;
      let delinearized = 0.0;
      if (normalized <= 0.0031308) {
        delinearized = normalized * 12.92;
      } else {
        delinearized = 1.055 * math.pow(normalized, 1.0 / 2.4)[$toDouble]() - 0.055;
      }
      return delinearized * 255.0;
    }
    static _chromaticAdaptation(component) {
      let af = math.pow(component[$abs](), 0.42)[$toDouble]();
      return math_utils.MathUtils.signum(component) * 400.0 * af / (af + 27.13);
    }
    static _hueOf(linrgb) {
      let scaledDiscount = math_utils.MathUtils.matrixMultiply(linrgb, cam_solver.CamSolver._SCALED_DISCOUNT_FROM_LINRGB);
      let rA = cam_solver.CamSolver._chromaticAdaptation(scaledDiscount[$_get](0));
      let gA = cam_solver.CamSolver._chromaticAdaptation(scaledDiscount[$_get](1));
      let bA = cam_solver.CamSolver._chromaticAdaptation(scaledDiscount[$_get](2));
      let a = (11.0 * rA + -12.0 * gA + bA) / 11.0;
      let b = (rA + gA - 2.0 * bA) / 9.0;
      return math.atan2(b, a);
    }
    static _areInCyclicOrder(a, b, c) {
      let deltaAB = cam_solver.CamSolver._sanitizeRadians(b - a);
      let deltaAC = cam_solver.CamSolver._sanitizeRadians(c - a);
      return deltaAB < deltaAC;
    }
    static _intercept(source, mid, target) {
      return (mid - source) / (target - source);
    }
    static _lerpPoint(source, t, target) {
      return T.JSArrayOfdouble().of([source[$_get](0) + (target[$_get](0) - source[$_get](0)) * t, source[$_get](1) + (target[$_get](1) - source[$_get](1)) * t, source[$_get](2) + (target[$_get](2) - source[$_get](2)) * t]);
    }
    static _setCoordinate(source, coordinate, target, axis) {
      let t = cam_solver.CamSolver._intercept(source[$_get](axis), coordinate, target[$_get](axis));
      return cam_solver.CamSolver._lerpPoint(source, t, target);
    }
    static _isBounded(x) {
      return 0.0 <= x && x <= 100.0;
    }
    static _edgePoints(y) {
      let kR = cam_solver.CamSolver._Y_FROM_LINRGB[$_get](0);
      let kG = cam_solver.CamSolver._Y_FROM_LINRGB[$_get](1);
      let kB = cam_solver.CamSolver._Y_FROM_LINRGB[$_get](2);
      let points = T.JSArrayOfListOfdouble().of([T.JSArrayOfdouble().of([y / kR, 0.0, 0.0]), T.JSArrayOfdouble().of([(y - 100 * kB) / kR, 0.0, 100.0]), T.JSArrayOfdouble().of([(y - 100 * kG) / kR, 100.0, 0.0]), T.JSArrayOfdouble().of([(y - 100 * kB - 100 * kG) / kR, 100.0, 100.0]), T.JSArrayOfdouble().of([0.0, y / kG, 0.0]), T.JSArrayOfdouble().of([100.0, (y - 100 * kR) / kG, 0.0]), T.JSArrayOfdouble().of([0.0, (y - 100 * kB) / kG, 100.0]), T.JSArrayOfdouble().of([100.0, (y - 100 * kR - 100 * kB) / kG, 100.0]), T.JSArrayOfdouble().of([0.0, 0.0, y / kB]), T.JSArrayOfdouble().of([100.0, 0.0, (y - 100 * kR) / kB]), T.JSArrayOfdouble().of([0.0, 100.0, (y - 100 * kG) / kB]), T.JSArrayOfdouble().of([100.0, 100.0, (y - 100 * kR - 100 * kG) / kB])]);
      return points[$where](dart.fn(element => cam_solver.CamSolver._isBounded(element[$_get](0)) && cam_solver.CamSolver._isBounded(element[$_get](1)) && cam_solver.CamSolver._isBounded(element[$_get](2)), T.ListOfdoubleTobool()))[$toList]();
    }
    static _bisectToSegment(y, targetHue) {
      let vertices = cam_solver.CamSolver._edgePoints(y);
      let left = vertices[$first];
      let right = left;
      let leftHue = cam_solver.CamSolver._hueOf(left);
      let rightHue = leftHue;
      let uncut = true;
      for (let mid of vertices[$skip](1)) {
        let midHue = cam_solver.CamSolver._hueOf(mid);
        if (uncut || cam_solver.CamSolver._areInCyclicOrder(leftHue, midHue, rightHue)) {
          uncut = false;
          if (cam_solver.CamSolver._areInCyclicOrder(leftHue, targetHue, midHue)) {
            right = mid;
            rightHue = midHue;
          } else {
            left = mid;
            leftHue = midHue;
          }
        }
      }
      return T.JSArrayOfListOfdouble().of([left, right]);
    }
    static _midpoint(a, b) {
      return T.JSArrayOfdouble().of([(a[$_get](0) + b[$_get](0)) / 2, (a[$_get](1) + b[$_get](1)) / 2, (a[$_get](2) + b[$_get](2)) / 2]);
    }
    static _criticalPlaneBelow(x) {
      return (x - 0.5)[$floor]();
    }
    static _criticalPlaneAbove(x) {
      return (x - 0.5)[$ceil]();
    }
    static _bisectToLimit(y, targetHue) {
      let segment = cam_solver.CamSolver._bisectToSegment(y, targetHue);
      let left = segment[$_get](0);
      let leftHue = cam_solver.CamSolver._hueOf(left);
      let right = segment[$_get](1);
      for (let axis = 0; axis < 3; axis = axis + 1) {
        if (left[$_get](axis) !== right[$_get](axis)) {
          let lPlane = -1;
          let rPlane = 255;
          if (left[$_get](axis) < right[$_get](axis)) {
            lPlane = cam_solver.CamSolver._criticalPlaneBelow(cam_solver.CamSolver._trueDelinearized(left[$_get](axis)));
            rPlane = cam_solver.CamSolver._criticalPlaneAbove(cam_solver.CamSolver._trueDelinearized(right[$_get](axis)));
          } else {
            lPlane = cam_solver.CamSolver._criticalPlaneAbove(cam_solver.CamSolver._trueDelinearized(left[$_get](axis)));
            rPlane = cam_solver.CamSolver._criticalPlaneBelow(cam_solver.CamSolver._trueDelinearized(right[$_get](axis)));
          }
          for (let i = 0; i < 8; i = i + 1) {
            if ((rPlane - lPlane)[$abs]() <= 1) {
              break;
            } else {
              let mPlane = ((lPlane + rPlane) / 2)[$floor]();
              let midPlaneCoordinate = cam_solver.CamSolver._CRITICAL_PLANES[$_get](mPlane);
              let mid = cam_solver.CamSolver._setCoordinate(left, midPlaneCoordinate, right, axis);
              let midHue = cam_solver.CamSolver._hueOf(mid);
              if (cam_solver.CamSolver._areInCyclicOrder(leftHue, targetHue, midHue)) {
                right = mid;
                rPlane = mPlane;
              } else {
                left = mid;
                leftHue = midHue;
                lPlane = mPlane;
              }
            }
          }
        }
      }
      return cam_solver.CamSolver._midpoint(left, right);
    }
    static _inverseChromaticAdaptation(adapted) {
      let adaptedAbs = adapted[$abs]();
      let base = math.max(core.num, 0, 27.13 * adaptedAbs / (400.0 - adaptedAbs));
      return math_utils.MathUtils.signum(adapted) * math.pow(base, 1.0 / 0.42)[$toDouble]();
    }
    static _findResultByJ(hueRadians, chroma, y) {
      let j = math.sqrt(y) * 11.0;
      let viewingConditions = viewing_conditions.ViewingConditions.standard;
      let tInnerCoeff = 1 / math.pow(1.64 - math.pow(0.29, viewingConditions.backgroundYTowhitePointY)[$toDouble](), 0.73)[$toDouble]();
      let eHue = 0.25 * (math.cos(hueRadians + 2.0) + 3.8);
      let p1 = eHue * (50000.0 / 13.0) * viewingConditions.nC * viewingConditions.ncb;
      let hSin = math.sin(hueRadians);
      let hCos = math.cos(hueRadians);
      for (let iterationRound = 0; iterationRound < 5; iterationRound = iterationRound + 1) {
        let jNormalized = j / 100.0;
        let alpha = chroma === 0.0 || j === 0.0 ? 0.0 : chroma / math.sqrt(jNormalized);
        let t = math.pow(alpha * tInnerCoeff, 1.0 / 0.9)[$toDouble]();
        let ac = viewingConditions.aw * math.pow(jNormalized, 1.0 / viewingConditions.c / viewingConditions.z)[$toDouble]();
        let p2 = ac / viewingConditions.nbb;
        let gamma = 23.0 * (p2 + 0.305) * t / (23.0 * p1 + 11 * t * hCos + 108.0 * t * hSin);
        let a = gamma * hCos;
        let b = gamma * hSin;
        let rA = (460.0 * p2 + 451.0 * a + 288.0 * b) / 1403.0;
        let gA = (460.0 * p2 - 891.0 * a - 261.0 * b) / 1403.0;
        let bA = (460.0 * p2 - 220.0 * a - 6300.0 * b) / 1403.0;
        let rCScaled = cam_solver.CamSolver._inverseChromaticAdaptation(rA);
        let gCScaled = cam_solver.CamSolver._inverseChromaticAdaptation(gA);
        let bCScaled = cam_solver.CamSolver._inverseChromaticAdaptation(bA);
        let linrgb = math_utils.MathUtils.matrixMultiply(T.JSArrayOfdouble().of([rCScaled, gCScaled, bCScaled]), cam_solver.CamSolver._LINRGB_FROM_SCALED_DISCOUNT);
        if (linrgb[$_get](0) < 0 || linrgb[$_get](1) < 0 || linrgb[$_get](2) < 0) {
          return 0;
        }
        let kR = cam_solver.CamSolver._Y_FROM_LINRGB[$_get](0);
        let kG = cam_solver.CamSolver._Y_FROM_LINRGB[$_get](1);
        let kB = cam_solver.CamSolver._Y_FROM_LINRGB[$_get](2);
        let fnj = kR * linrgb[$_get](0) + kG * linrgb[$_get](1) + kB * linrgb[$_get](2);
        if (fnj <= 0) {
          return 0;
        }
        if (iterationRound === 4 || (fnj - y)[$abs]() < 0.002) {
          if (linrgb[$_get](0) > 100.01 || linrgb[$_get](1) > 100.01 || linrgb[$_get](2) > 100.01) {
            return 0;
          }
          return color_utils.ColorUtils.argbFromLinrgb(linrgb);
        }
        j = j - (fnj - y) * j / (2 * fnj);
      }
      return 0;
    }
    static solveToInt(hueDegrees, chroma, lstar) {
      if (chroma < 0.0001 || lstar < 0.0001 || lstar > 99.9999) {
        return color_utils.ColorUtils.argbFromLstar(lstar);
      }
      hueDegrees = math_utils.MathUtils.sanitizeDegreesDouble(hueDegrees);
      let hueRadians = hueDegrees / 180 * 3.141592653589793;
      let y = color_utils.ColorUtils.yFromLstar(lstar);
      let exactAnswer = cam_solver.CamSolver._findResultByJ(hueRadians, chroma, y);
      if (exactAnswer !== 0) {
        return exactAnswer;
      }
      let linrgb = cam_solver.CamSolver._bisectToLimit(y, hueRadians);
      return color_utils.ColorUtils.argbFromLinrgb(linrgb);
    }
    static solveToCam(hueDegrees, chroma, lstar) {
      return cam16.Cam16.fromInt(cam_solver.CamSolver.solveToInt(hueDegrees, chroma, lstar));
    }
    static ['_#new#tearOff']() {
      return new cam_solver.CamSolver.new();
    }
  };
  (cam_solver.CamSolver.new = function() {
    ;
  }).prototype = cam_solver.CamSolver.prototype;
  dart.addTypeTests(cam_solver.CamSolver);
  dart.addTypeCaches(cam_solver.CamSolver);
  dart.setStaticMethodSignature(cam_solver.CamSolver, () => ['_sanitizeRadians', '_trueDelinearized', '_chromaticAdaptation', '_hueOf', '_areInCyclicOrder', '_intercept', '_lerpPoint', '_setCoordinate', '_isBounded', '_edgePoints', '_bisectToSegment', '_midpoint', '_criticalPlaneBelow', '_criticalPlaneAbove', '_bisectToLimit', '_inverseChromaticAdaptation', '_findResultByJ', 'solveToInt', 'solveToCam']);
  dart.setLibraryUri(cam_solver.CamSolver, I[0]);
  dart.setStaticFieldSignature(cam_solver.CamSolver, () => ['_SCALED_DISCOUNT_FROM_LINRGB', '_LINRGB_FROM_SCALED_DISCOUNT', '_Y_FROM_LINRGB', '_CRITICAL_PLANES']);
  dart.defineLazy(cam_solver.CamSolver, {
    /*cam_solver.CamSolver._SCALED_DISCOUNT_FROM_LINRGB*/get _SCALED_DISCOUNT_FROM_LINRGB() {
      return T.JSArrayOfListOfdouble().of([T.JSArrayOfdouble().of([0.001200833568784504, 0.002389694492170889, 0.0002795742885861124]), T.JSArrayOfdouble().of([0.0005891086651375999, 0.0029785502573438758, 0.0003270666104008398]), T.JSArrayOfdouble().of([0.00010146692491640572, 0.0005364214359186694, 0.0032979401770712076])]);
    },
    /*cam_solver.CamSolver._LINRGB_FROM_SCALED_DISCOUNT*/get _LINRGB_FROM_SCALED_DISCOUNT() {
      return T.JSArrayOfListOfdouble().of([T.JSArrayOfdouble().of([1373.2198709594231, -1100.4251190754821, -7.278681089101213]), T.JSArrayOfdouble().of([-271.815969077903, 559.6580465940733, -32.46047482791194]), T.JSArrayOfdouble().of([1.9622899599665666, -57.173814538844006, 308.7233197812385])]);
    },
    /*cam_solver.CamSolver._Y_FROM_LINRGB*/get _Y_FROM_LINRGB() {
      return T.JSArrayOfdouble().of([0.2126, 0.7152, 0.0722]);
    },
    /*cam_solver.CamSolver._CRITICAL_PLANES*/get _CRITICAL_PLANES() {
      return T.JSArrayOfdouble().of([0.015176349177441876, 0.045529047532325624, 0.07588174588720938, 0.10623444424209313, 0.13658714259697685, 0.16693984095186062, 0.19729253930674434, 0.2276452376616281, 0.2579979360165119, 0.28835063437139563, 0.3188300904430532, 0.350925934958123, 0.3848314933096426, 0.42057480301049466, 0.458183274052838, 0.4976837250274023, 0.5391024159806381, 0.5824650784040898, 0.6277969426914107, 0.6751227633498623, 0.7244668422128921, 0.775853049866786, 0.829304845476233, 0.8848452951698498, 0.942497089126609, 1.0022825574869039, 1.0642236851973577, 1.1283421258858297, 1.1946592148522128, 1.2631959812511864, 1.3339731595349034, 1.407011200216447, 1.4823302800086415, 1.5599503113873272, 1.6398909516233677, 1.7221716113234105, 1.8068114625156377, 1.8938294463134073, 1.9832442801866852, 2.075074464868551, 2.1693382909216234, 2.2660538449872063, 2.36523901573795, 2.4669114995532007, 2.5710888059345764, 2.6777882626779785, 2.7870270208169257, 2.898822059350997, 3.0131901897720907, 3.1301480604002863, 3.2497121605402226, 3.3718988244681087, 3.4967242352587946, 3.624204428461639, 3.754355295633311, 3.887192587735158, 4.022731918402185, 4.160988767090289, 4.301978482107941, 4.445716283538092, 4.592217266055746, 4.741496401646282, 4.893568542229298, 5.048448422192488, 5.20615066083972, 5.3666897647573375, 5.5300801301023865, 5.696336044816294, 5.865471690767354, 6.037501145825082, 6.212438385869475, 6.390297286737924, 6.571091626112461, 6.7548350853498045, 6.941541251256611, 7.131223617812143, 7.323895587840543, 7.5195704746346665, 7.7182615035334345, 7.919981813454504, 8.124744458384042, 8.332562408825165, 8.543448553206703, 8.757415699253682, 8.974476575321063, 9.194643831691977, 9.417930041841839, 9.644347703669503, 9.873909240696694, 10.106627003236781, 10.342513269534024, 10.58158024687427, 10.8238400726681, 11.069304815507364, 11.317986476196008, 11.569896988756009, 11.825048221409341, 12.083451977536606, 12.345119996613247, 12.610063955123938, 12.878295467455942, 13.149826086772048, 13.42466730586372, 13.702830557985108, 13.984327217668513, 14.269168601521828, 14.55736596900856, 14.848930523210871, 15.143873411576273, 15.44220572664832, 15.743938506781891, 16.04908273684337, 16.35764934889634, 16.66964922287304, 16.985093187232053, 17.30399201960269, 17.62635644741625, 17.95219714852476, 18.281524751807332, 18.614349837764564, 18.95068293910138, 19.290534541298456, 19.633915083172692, 19.98083495742689, 20.331304511189067, 20.685334046541502, 21.042933821039977, 21.404114048223256, 21.76888489811322, 22.137256497705877, 22.50923893145328, 22.884842241736916, 23.264076429332462, 23.6469514538663, 24.033477234264016, 24.42366364919083, 24.817520537484558, 25.21505769858089, 25.61628489293138, 26.021211842414342, 26.429848230738664, 26.842203703840827, 27.258287870275353, 27.678110301598522, 28.10168053274597, 28.529008062403893, 28.96010235337422, 29.39497283293396, 29.83362889318845, 30.276079891419332, 30.722335150426627, 31.172403958865512, 31.62629557157785, 32.08401920991837, 32.54558406207592, 33.010999283389665, 33.4802739966603, 33.953417292456834, 34.430438229418264, 34.911345834551085, 35.39614910352207, 35.88485700094671, 36.37747846067349, 36.87402238606382, 37.37449765026789, 37.87891309649659, 38.38727753828926, 38.89959975977785, 39.41588851594697, 39.93615253289054, 40.460400508064545, 40.98864111053629, 41.520882981230194, 42.05713473317016, 42.597404951718396, 43.141702194811224, 43.6900349931913, 44.24241185063697, 44.798841244188324, 45.35933162437017, 45.92389141541209, 46.49252901546552, 47.065252796817916, 47.64207110610409, 48.22299226451468, 48.808024568002054, 49.3971762874833, 49.9904556690408, 50.587870934119984, 51.189430279724725, 51.79514187861014, 52.40501387947288, 53.0190544071392, 53.637271562750364, 54.259673423945976, 54.88626804504493, 55.517063457223934, 56.15206766869424, 56.79128866487574, 57.43473440856916, 58.08241284012621, 58.734331877617365, 59.39049941699807, 60.05092333227251, 60.715611475655585, 61.38457167773311, 62.057811747619894, 62.7353394731159, 63.417162620860914, 64.10328893648692, 64.79372614476921, 65.48848194977529, 66.18756403501224, 66.89098006357258, 67.59873767827808, 68.31084450182222, 69.02730813691093, 69.74813616640164, 70.47333615344107, 71.20291564160104, 71.93688215501312, 72.67524319850172, 73.41800625771542, 74.16517879925733, 74.9167682708136, 75.67278210128072, 76.43322770089146, 77.1981124613393, 77.96744375590167, 78.74122893956174, 79.51947534912904, 80.30219030335869, 81.08938110306934, 81.88105503125999, 82.67721935322541, 83.4778813166706, 84.28304815182372, 85.09272707154808, 85.90692527145302, 86.72564993000343, 87.54890820862819, 88.3767072518277, 89.2090541872801, 90.04595612594655, 90.88742016217518, 91.73345337380438, 92.58406282226491, 93.43925555268066, 94.29903859396902, 95.16341895893969, 96.03240364439274, 96.9059996312159, 97.78421388448044, 98.6670533535366, 99.55452497210776]);
    }
  }, false);
  dart.trackLibraries("packages/material_color_utilities/hct/cam_solver.dart", {
    "package:material_color_utilities/hct/cam_solver.dart": cam_solver
  }, {
  }, '{"version":3,"sourceRoot":"","sources":["cam_solver.dart"],"names":[],"mappings":"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BACA,oBACA,oBACA,oBACA,oBACA,oBACA,mBACA,oBACA,oBACA,kBACA,oBACA,oBACA,oBACA,oBACA,mBACA,oBACA,oBACA,oBACA,oBACA,oBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,kBACA,oBACA,oBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,oBACA,mBACA,mBACA,mBACA,oBACA,oBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,oBACA,oBACA,mBACA,kBACA,oBACA,oBACA,oBACA,oBACA,oBACA,oBACA,oBACA,oBACA,oBACA,mBACA,oBACA,oBACA,oBACA,mBACA,oBACA,oBACA,mBACA,oBACA,mBACA,mBACA,mBACA,oBACA,mBACA,mBACA,mBACA,oBACA,oBACA,mBACA,oBACA,oBACA,mBACA,oBACA,oBACA,oBACA,oBACA,mBACA,oBACA,mBACA,oBACA,oBACA,kBACA,oBACA,mBACA,oBACA,mBACA,mBACA,oBACA,oBACA,oBACA,oBACA,oBACA,mBACA,oBACA,mBACA,mBACA,mBACA,oBACA,oBACA,oBACA,mBACA,mBACA,mBACA,oBACA,kBACA,oBACA,oBACA,oBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,oBACA,mBACA,oBACA,mBACA,oBACA,oBACA,kBACA,mBACA,oBACA,mBACA,mBACA,mBACA,oBACA,mBACA,mBACA,oBACA,kBACA,kBACA,oBACA,oBACA,mBACA,mBACA,kBACA,oBACA,oBACA,mBACA,oBACA,mBACA,mBACA,mBACA,mBACA,oBACA,mBACA,mBACA,oBACA,mBACA,oBACA,kBACA,oBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,kBACA,mBACA,mBACA,kBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,kBACA,mBACA,mBACA,mBACA,mBACA,mBACA,kBACA,kBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,mBACA,kBACA,mBACA,kBACA","file":"../../../../../../../../../../../packages/material_color_utilities/hct/cam_solver.dart.lib.js"}');
  // Exports:
  return {
    hct__cam_solver: cam_solver
  };
}));

//# sourceMappingURL=cam_solver.dart.lib.js.map

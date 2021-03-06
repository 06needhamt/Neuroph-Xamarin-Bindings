using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='SupervisedHebbianNetwork']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/SupervisedHebbianNetwork", DoNotGenerateAcw=true)]
	public partial class SupervisedHebbianNetwork : global::Org.Neuroph.Core.NeuralNetwork {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/SupervisedHebbianNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupervisedHebbianNetwork); }
		}

		protected SupervisedHebbianNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='SupervisedHebbianNetwork']/constructor[@name='SupervisedHebbianNetwork' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe SupervisedHebbianNetwork (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SupervisedHebbianNetwork)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IILorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='SupervisedHebbianNetwork']/constructor[@name='SupervisedHebbianNetwork' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.neuroph.util.TransferFunctionType']]"
		[Register (".ctor", "(IILorg/neuroph/util/TransferFunctionType;)V", "")]
		public unsafe SupervisedHebbianNetwork (int p0, int p1, global::Org.Neuroph.Util.TransferFunctionType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SupervisedHebbianNetwork)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILorg/neuroph/util/TransferFunctionType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILorg/neuroph/util/TransferFunctionType;)V", __args);
					return;
				}

				if (id_ctor_IILorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
					id_ctor_IILorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILorg/neuroph/util/TransferFunctionType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILorg_neuroph_util_TransferFunctionType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILorg_neuroph_util_TransferFunctionType_, __args);
			} finally {
			}
		}

	}
}

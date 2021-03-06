using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Imgrec.Image {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']"
	[Register ("org/neuroph/contrib/imgrec/image/Image", "", "Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker")]
	public partial interface IImage : IJavaObject {

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")] get;
		}

		int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")] get;
		}

		int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='cropImage' and count(parameter)=5 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("cropImage", "(Lorg/neuroph/contrib/imgrec/image/Image;IIII)Lorg/neuroph/contrib/imgrec/image/Image;", "GetCropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIIIHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")]
		global::Org.Neuroph.Contrib.Imgrec.Image.IImage CropImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1, int p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='getPixel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPixel", "(II)I", "GetGetPixel_IIHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")]
		int GetPixel (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='getPixels' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("getPixels", "(IIIIII)[I", "GetGetPixels_IIIIIIHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")]
		int[] GetPixels (int p0, int p1, int p2, int p3, int p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='resizeImage' and count(parameter)=3 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("resizeImage", "(Lorg/neuroph/contrib/imgrec/image/Image;II)Lorg/neuroph/contrib/imgrec/image/Image;", "GetResizeImage_Lorg_neuroph_contrib_imgrec_image_Image_IIHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")]
		global::Org.Neuroph.Contrib.Imgrec.Image.IImage ResizeImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='setPixel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setPixel", "(III)V", "GetSetPixel_IIIHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")]
		void SetPixel (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/interface[@name='Image']/method[@name='setPixels' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("setPixels", "([IIIIIII)V", "GetSetPixels_arrayIIIIIIIHandler:Org.Neuroph.Contrib.Imgrec.Image.IImageInvoker, Neuroph_2.6")]
		void SetPixels (int[] p0, int p1, int p2, int p3, int p4, int p5, int p6);

	}

	[global::Android.Runtime.Register ("org/neuroph/contrib/imgrec/image/Image", DoNotGenerateAcw=true)]
	internal class IImageInvoker : global::Java.Lang.Object, IImage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/contrib/imgrec/image/Image");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageInvoker); }
		}

		IntPtr class_ref;

		public static IImage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.contrib.imgrec.image.Image"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public unsafe int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
			}
		}

		static Delegate cb_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII;
#pragma warning disable 0169
		static Delegate GetCropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIIIHandler ()
		{
			if (cb_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII == null)
				cb_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_CropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII);
			return cb_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII;
		}

		static IntPtr n_CropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0 = (global::Org.Neuroph.Contrib.Imgrec.Image.IImage)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CropImage (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII;
		public unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage CropImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1, int p2, int p3, int p4)
		{
			if (id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII == IntPtr.Zero)
				id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII = JNIEnv.GetMethodID (class_ref, "cropImage", "(Lorg/neuroph/contrib/imgrec/image/Image;IIII)Lorg/neuroph/contrib/imgrec/image/Image;");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getPixel_II;
#pragma warning disable 0169
		static Delegate GetGetPixel_IIHandler ()
		{
			if (cb_getPixel_II == null)
				cb_getPixel_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetPixel_II);
			return cb_getPixel_II;
		}

		static int n_GetPixel_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPixel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPixel_II;
		public unsafe int GetPixel (int p0, int p1)
		{
			if (id_getPixel_II == IntPtr.Zero)
				id_getPixel_II = JNIEnv.GetMethodID (class_ref, "getPixel", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPixel_II, __args);
		}

		static Delegate cb_getPixels_IIIIII;
#pragma warning disable 0169
		static Delegate GetGetPixels_IIIIIIHandler ()
		{
			if (cb_getPixels_IIIIII == null)
				cb_getPixels_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>) n_GetPixels_IIIIII);
			return cb_getPixels_IIIIII;
		}

		static IntPtr n_GetPixels_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPixels (p0, p1, p2, p3, p4, p5));
		}
#pragma warning restore 0169

		IntPtr id_getPixels_IIIIII;
		public unsafe int[] GetPixels (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_getPixels_IIIIII == IntPtr.Zero)
				id_getPixels_IIIIII = JNIEnv.GetMethodID (class_ref, "getPixels", "(IIIIII)[I");
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPixels_IIIIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II;
#pragma warning disable 0169
		static Delegate GetResizeImage_Lorg_neuroph_contrib_imgrec_image_Image_IIHandler ()
		{
			if (cb_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II == null)
				cb_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_ResizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II);
			return cb_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II;
		}

		static IntPtr n_ResizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0 = (global::Org.Neuroph.Contrib.Imgrec.Image.IImage)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResizeImage (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II;
		public unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage ResizeImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1, int p2)
		{
			if (id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II == IntPtr.Zero)
				id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II = JNIEnv.GetMethodID (class_ref, "resizeImage", "(Lorg/neuroph/contrib/imgrec/image/Image;II)Lorg/neuroph/contrib/imgrec/image/Image;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setPixel_III;
#pragma warning disable 0169
		static Delegate GetSetPixel_IIIHandler ()
		{
			if (cb_setPixel_III == null)
				cb_setPixel_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetPixel_III);
			return cb_setPixel_III;
		}

		static void n_SetPixel_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixel (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setPixel_III;
		public unsafe void SetPixel (int p0, int p1, int p2)
		{
			if (id_setPixel_III == IntPtr.Zero)
				id_setPixel_III = JNIEnv.GetMethodID (class_ref, "setPixel", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPixel_III, __args);
		}

		static Delegate cb_setPixels_arrayIIIIIII;
#pragma warning disable 0169
		static Delegate GetSetPixels_arrayIIIIIIIHandler ()
		{
			if (cb_setPixels_arrayIIIIIII == null)
				cb_setPixels_arrayIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int>) n_SetPixels_arrayIIIIIII);
			return cb_setPixels_arrayIIIIIII;
		}

		static void n_SetPixels_arrayIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetPixels (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setPixels_arrayIIIIIII;
		public unsafe void SetPixels (int[] p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_setPixels_arrayIIIIIII == IntPtr.Zero)
				id_setPixels_arrayIIIIIII = JNIEnv.GetMethodID (class_ref, "setPixels", "([IIIIIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPixels_arrayIIIIIII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}

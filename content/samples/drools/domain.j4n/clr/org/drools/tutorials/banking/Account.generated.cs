//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.tutorials.banking {
    
    
    #region Component Designer generated code 
    public partial class Account_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.tutorials.banking.@__Account.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.tutorials.banking.Account), typeof(global::org.drools.tutorials.banking.Account_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.tutorials.banking.Account), typeof(global::org.drools.tutorials.banking.Account_))]
    internal sealed partial class @__Account : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Account(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.tutorials.banking.@__Account.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Account);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAccountNo", "AccountNo0", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setAccountNo", "AccountNo1", "(J)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBalance", "Balance2", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setBalance", "Balance3", "(D)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorAccount0", "__ctorAccount0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorAccount1", "__ctorAccount1", "(Lnet/sf/jni4net/inj/IClrProxy;J)V"));
            return methods;
        }
        
        private static long AccountNo0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::org.drools.tutorials.banking.Account @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::org.drools.tutorials.banking.Account>(@__env, @__obj);
            @__return = ((long)(@__real.AccountNo));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void AccountNo1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, long value) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.tutorials.banking.Account @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::org.drools.tutorials.banking.Account>(@__env, @__obj);
            @__real.AccountNo = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static double Balance2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::org.drools.tutorials.banking.Account @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::org.drools.tutorials.banking.Account>(@__env, @__obj);
            @__return = ((double)(@__real.Balance));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void Balance3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, double value) {
            // (D)V
            // (D)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.tutorials.banking.Account @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::org.drools.tutorials.banking.Account>(@__env, @__obj);
            @__real.Balance = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorAccount0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.tutorials.banking.Account @__real = new global::org.drools.tutorials.banking.Account();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorAccount1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, long accountNo) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.tutorials.banking.Account @__real = new global::org.drools.tutorials.banking.Account(accountNo);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.tutorials.banking.@__Account(@__env);
            }
        }
    }
    #endregion
}

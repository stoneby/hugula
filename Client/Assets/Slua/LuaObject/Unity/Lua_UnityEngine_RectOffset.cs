﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RectOffset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.RectOffset o;
			if(argc==1){
				o=new UnityEngine.RectOffset();
				pushValue(l,o);
				return 1;
			}
			else if(argc==5){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				o=new UnityEngine.RectOffset(a1,a2,a3,a4);
				pushValue(l,o);
				return 1;
			}
			LuaDLL.luaL_error(l,"New object failed.");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			var ret=self.Add(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			var ret=self.Remove(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_left(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,self.left);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_left(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.left=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,self.right);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_right(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.right=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_top(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,self.top);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_top(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.top=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottom(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,self.bottom);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottom(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.bottom=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontal(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,self.horizontal);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertical(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,self.vertical);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RectOffset");
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,"left",get_left,set_left,true);
		addMember(l,"right",get_right,set_right,true);
		addMember(l,"top",get_top,set_top,true);
		addMember(l,"bottom",get_bottom,set_bottom,true);
		addMember(l,"horizontal",get_horizontal,null,true);
		addMember(l,"vertical",get_vertical,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RectOffset));
	}
}

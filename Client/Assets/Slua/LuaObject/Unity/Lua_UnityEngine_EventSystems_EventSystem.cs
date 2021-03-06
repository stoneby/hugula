﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModules(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			self.UpdateModules();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSelectedGameObject(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				self.SetSelectedGameObject(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				UnityEngine.EventSystems.BaseEventData a2;
				checkType(l,3,out a2);
				self.SetSelectedGameObject(a1,a2);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RaycastAll(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> a2;
			checkType(l,3,out a2);
			self.RaycastAll(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerOverGameObject(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
				var ret=self.IsPointerOverGameObject();
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.IsPointerOverGameObject(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		try {
			pushValue(l,UnityEngine.EventSystems.EventSystem.current);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem v;
			checkType(l,2,out v);
			UnityEngine.EventSystems.EventSystem.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sendNavigationEvents(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.sendNavigationEvents);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sendNavigationEvents(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.sendNavigationEvents=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelDragThreshold(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.pixelDragThreshold);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelDragThreshold(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.pixelDragThreshold=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentInputModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.currentInputModule);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_firstSelectedGameObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.firstSelectedGameObject);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_firstSelectedGameObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.firstSelectedGameObject=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentSelectedGameObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.currentSelectedGameObject);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastSelectedGameObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.lastSelectedGameObject);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alreadySelecting(IntPtr l) {
		try {
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
			pushValue(l,self.alreadySelecting);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.EventSystem");
		addMember(l,UpdateModules);
		addMember(l,SetSelectedGameObject);
		addMember(l,RaycastAll);
		addMember(l,IsPointerOverGameObject);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"sendNavigationEvents",get_sendNavigationEvents,set_sendNavigationEvents,true);
		addMember(l,"pixelDragThreshold",get_pixelDragThreshold,set_pixelDragThreshold,true);
		addMember(l,"currentInputModule",get_currentInputModule,null,true);
		addMember(l,"firstSelectedGameObject",get_firstSelectedGameObject,set_firstSelectedGameObject,true);
		addMember(l,"currentSelectedGameObject",get_currentSelectedGameObject,null,true);
		addMember(l,"lastSelectedGameObject",get_lastSelectedGameObject,null,true);
		addMember(l,"alreadySelecting",get_alreadySelecting,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.EventSystem),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}

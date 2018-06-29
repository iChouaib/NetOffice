#include "stdafx.h"
#include "ShimProxyFactory.h"
#include "Vars.hpp"
#include "DllRegister.h"
#include "ShimArguments.h"

HINSTANCE _module = NULL;   // DLL module handle
ULONG _components = 0;      // Count of active components
ULONG _locks = 0;			// Count of server locks

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
		case DLL_PROCESS_ATTACH:
		{
			_module = hModule;
			::DisableThreadLibraryCalls(hModule);
			ShimArguments* args = new ShimArguments();
			args->Load();
			delete args;
			break;
		}
		case DLL_THREAD_ATTACH:
		case DLL_THREAD_DETACH:
		case DLL_PROCESS_DETACH:
			break;
    }
    return TRUE;
}

STDAPI DllCanUnloadNow()
{
	return (_components == 0 && _locks == 0) ? S_OK : S_FALSE;
}

STDAPI DllGetClassObject(REFCLSID rclsid, REFIID riid, void** ppv)
{
	*ppv = NULL;

	if (rclsid != ShimProxy_CLSID)
		return CLASS_E_CLASSNOTAVAILABLE;

	ShimProxyFactory* pCF = new (std::nothrow) ShimProxyFactory();
	if (NULL == pCF)
		return E_OUTOFMEMORY;

	HRESULT hr = pCF->QueryInterface(riid, ppv);
	if (FAILED(hr))
	{
		*ppv = NULL;
		delete pCF;
	}

	return hr;
}

STDAPI DllRegisterServer()
{
	if(ENABLE_SELF_REGISTRATION)
		return DllRegister(_module, ShimProxy_Host_Application, 3, ShimProxy_ProgID, ShimProxy_CLSID_Text, ShimProxy_Description, System);
	else
		return S_OK;
}

STDAPI DllUnregisterServer()
{
	if (ENABLE_SELF_REGISTRATION)
		return DllUnregister(ShimProxy_Host_Application, ShimProxy_ProgID, ShimProxy_CLSID_Text, System);
	else
		return S_OK;
}

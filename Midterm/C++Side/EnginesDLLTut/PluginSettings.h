#pragma once
#ifdef PLUGIN_EXPORT
#define PLUGIN_API _declspec(dllexport)
#elif PLUGIN_EXPORT
#define PLUGIN_API _declspec(dllimport)
#else
#define PLUGIN_API
#endif
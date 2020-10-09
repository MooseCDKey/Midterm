#include "Wrapper.h"

CheckpointTimeLogger timeLogger;

PLUGIN_API void ResetLogger()
{
	return timeLogger.ResetLogger();
}

PLUGIN_API void SaveCheckpointTime(float RTBC)
{
	return timeLogger.SaveCheckPointTime(RTBC);
}

PLUGIN_API float GetTotalTime()
{
	return timeLogger.GetTotalTime();
}

PLUGIN_API float GetCheckpointTime(int index)
{
	return timeLogger.GetCheckpointTime(index);
}
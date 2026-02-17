using System.Collections.Generic;
using FMOD.Studio;

public class MusicBoxIdle
{
	private List<BaseSimObject> _toRemove = new List<BaseSimObject>();

	public Dictionary<BaseSimObject, EventInstance> currentAttachedSounds = new Dictionary<BaseSimObject, EventInstance>();

	private float _timer;

	public void update(float pElapsed)
	{
		if (_timer > 2f)
		{
			_timer -= pElapsed;
			return;
		}
		_timer = 2f;
		_toRemove.Clear();
		if (World.world.quality_changer.isLowRes())
		{
			clearAllSounds();
		}
		checkDeadSounds();
		if (!World.world.quality_changer.isLowRes())
		{
			updateBuildings();
		}
	}

	public virtual void checkDeadSounds()
	{
		foreach (BaseSimObject key in currentAttachedSounds.Keys)
		{
			bool flag = false;
			if (!key.isAlive())
			{
				flag = true;
			}
			if (flag)
			{
				_toRemove.Add(key);
			}
		}
		foreach (BaseSimObject item in _toRemove)
		{
			removeSound(item);
		}
	}

	private void updateBuildings()
	{
	}

	private void removeSound(BaseSimObject pObj)
	{
		currentAttachedSounds.TryGetValue(pObj, out var value);
		if (value.isValid())
		{
			value.stop(STOP_MODE.ALLOWFADEOUT);
			value.release();
			currentAttachedSounds.Remove(pObj);
		}
	}

	private void playAttachedSound(BaseSimObject pObject, string pSound)
	{
		if (MusicBox.sounds_on)
		{
			currentAttachedSounds.TryGetValue(pObject, out var value);
			if (!value.isValid())
			{
				currentAttachedSounds.Add(pObject, value);
			}
		}
	}

	private bool isPlaying(BaseSimObject pObject)
	{
		currentAttachedSounds.TryGetValue(pObject, out var value);
		if (value.isValid())
		{
			return true;
		}
		return false;
	}

	public void clearAllSounds()
	{
		foreach (EventInstance value in currentAttachedSounds.Values)
		{
			value.stop(STOP_MODE.ALLOWFADEOUT);
			value.release();
		}
		currentAttachedSounds.Clear();
	}

	public int CountCurrentSounds()
	{
		return currentAttachedSounds.Count;
	}
}

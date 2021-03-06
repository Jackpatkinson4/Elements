﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerDummySpawn : MobSpawn
{
	private static UnityEngine.Object[] worker_dummy_objects;

	private static EntityClass type = EntityClass.WorkerDummySpawn;

	bool ready = false;

	public override GameObject spawn(Transform transformation){
		//GameObject mob = Instantiate(worker_dummy_objects[0], transformation.position, transformation.rotation) as GameObject;
		GameObject mob = Instantiate(worker_dummy_objects[Random.Range(0, worker_dummy_objects.Length)], transformation.position, transformation.rotation) as GameObject;
		mob.AddComponent<MobAI>().path = this.path;
		this.spawned_mobs.Add(mob);
		return mob;
	}

	void Start()
	{
		worker_dummy_objects = Resources.LoadAll("Workers");
		base.type = type;
		this.ready = true;
	}
}
